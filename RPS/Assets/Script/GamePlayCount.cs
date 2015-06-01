using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ゲームプレイ中のカウントダウン
/// </summary>
public class GamePlayCount : MonoBehaviour {

    /// <summary>
    /// カウントダウンの表示
    /// </summary>
    [SerializeField]
    private Text timeCount = null;
    /// <summary>
    /// カウントダウンの初期値
    /// </summary>
    [SerializeField]
    private float startTime = 31.0f;
    /// <summary>
    /// カウントダウン
    /// </summary>
    private float timer = 0.0f;
    /// <summary>
    /// カウントダウンを開始するか
    /// </summary>
    private bool CountDownStart = false;
    /// <summary>
    /// 敵の手
    /// </summary>
    private EnemyHand enemyHand = null;
    /// <summary>
    /// 条件選択
    /// </summary>
    private ConditioSelection conditioSelection = null;
    /// <summary>
    /// プレーヤーの手
    /// </summary>
    private PlayerHand playerHand = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
    {
        conditioSelection = GetComponent<ConditioSelection>();
        enemyHand = GetComponent<EnemyHand>();
        playerHand = GetComponent<PlayerHand>();
        timer = startTime;                      //  タイムセット
        timeCount.enabled = false;              //  非表示に
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
    public void StartGame()
    {
        timeCount.enabled = true;                       //  表示へ  
        CountDownStart = true;                          //  カウントダウンの開始に
    }

    /// <summary>
    /// カウントダウン
    /// </summary>
    private void CountDown()
    {
        if (CountDownStart == false) return;            //  カウントダウンの開始タイミング

        timer -= Time.deltaTime;                        //  時間を減らす
        var temp = (int)timer;                          //  タイム表示のために小数点切り捨て
        if (timer >= 1.0f)                              //  1s以上なら
        {
            timeCount.text = " " + temp.ToString();     //  数字をまんま表示
        }
        else if (timer < 1.0f)                          //  1s未満で
        {
			timeCount.text = "終了";                    //  Goを表示
            conditioSelection.EndGame();                //  非表示に
        }
        if (timer <= 0.0f)                              //  0s以下で
        {
			Application.LoadLevel("Result");            // Resetシーン移動  
        }
    }

}
