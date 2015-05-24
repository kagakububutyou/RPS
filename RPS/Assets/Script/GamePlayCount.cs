using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ゲームプレイ中のカウントダウン
/// </summary>
public class GamePlayCount : MonoBehaviour {

    [SerializeField]
    private Text timeCount = null;              //  カウントダウンの表示
    [SerializeField]
    private float startTime = 31.0f;            //  カウントダウンの初期値
    private float timer = 0.0f;                 //  カウントダウン用
    private bool CountDownStart = false;        //  カウントダウン開始
    [SerializeField]
    private Object screen = null;               //  シーンの取得
    private EnemyHand enemyHand = null;                         //  敵の手
    private ConditioSelection conditioSelection = null;         //  条件選択

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
    {
        conditioSelection = GetComponent<ConditioSelection>();  //  条件選択のコンポーネントの取得
        enemyHand = GetComponent<EnemyHand>();                  //  敵の手のコンポーネントの取得
        timer = startTime;                      //  タイムセット
        timeCount.text = "";                    //  中身を空にする
	}
	
	/// <summary>
    /// 更新は、フレームごとに一度呼ばれています
	/// </summary>
	private void Update () 
    {
        CountDown();
	}
    /// <summary>
    /// カウントダウン開始
    /// </summary>
    public void GameStart()
    {
        CountDownStart = true;
    }

    /// <summary>
    /// カウントダウン
    /// </summary>
    private void CountDown()
    {
        if (CountDownStart == false) return;

        timer -= Time.deltaTime;                        //  時間を減らす
        var temp = (int)timer;                          //  タイム表示のために小数点切り捨て
        if (timer >= 1.0f)                              //  1s以上なら
        {
            timeCount.text = " " + temp.ToString();     //  数字をまんま表示
        }
        else if (timer < 1.0f)                          //  1s未満で
        {
            timeCount.text = "End";                     //  Goを表示
            conditioSelection.ChangeDrawMode(false);    //  非表示に
            enemyHand.ChangeDrawMode(false);            //  非表示に
        }
        if (timer <= 0.0f)                              //  0s以下で
        {
			Application.LoadLevel("Result");         // Resetシーン移動  
        }
    }

}
