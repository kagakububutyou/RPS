using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
/// <summary>
/// カウントダウン用
/// </summary>
public class GameStartCountDown : MonoBehaviour {

    [SerializeField]
    private Text timeCount = null;                              //  カウントダウンの表示
    [SerializeField]
    private float startTime = 3.0f;                             //  カウントダウンの初期値
    private float timer = 0.0f;                                 //  カウントダウン用
    private EnemyHand enemyHand = null;                         //  敵の手
    private ConditioSelection conditioSelection = null;         //  条件選択
    private GamePlayCount gamePlayCount = null;                 //  ゲームプレイ中のカウントダウン
	/// <summary>
	/// timerにタイムを代入
	/// </summary>
	private void Start () 
    {
        conditioSelection = GetComponent<ConditioSelection>();  //  条件選択のコンポーネントの取得
        enemyHand = GetComponent<EnemyHand>();                  //  敵の手のコンポーネントの取得
        gamePlayCount = GetComponent<GamePlayCount>();          //  ゲームプレイ中のカウントダウンのコンポーネントの取得
        timer = startTime;                                      //  タイムセット
	}

    /// <summary>
    /// 更新は、フレームごとに一度呼ばれています
    /// </summary>
    private	void Update () 
    {
        CountDown();
	}

    /// <summary>
    /// カウントダウン
    /// </summary>
    private void CountDown()
    {
        if (timeCount.enabled == false) return;

        timer -= Time.deltaTime;                        //  時間を減らす
        var temp = (int)timer;                          //  タイム表示のために小数点切り捨て
        if (timer >= 1.0f)                              //  1s以上なら
        {
            timeCount.text = "  " + temp.ToString();    //  数字をまんま表示
        }
        else if (timer < 1.0f)                          //  1s未満で
        {
            timeCount.text = "GO!";                     //  Goを表示
        }
        if (timer <= 0.0f)                              //  0s以下で
        {
            conditioSelection.ChangeDrawMode(true);     //  カウントダウンがゼロになったら呼ぶ
            enemyHand.ChangeDrawMode(true);             //  カウントダウンがゼロになったら呼ぶ
            gamePlayCount.GameStart();                  //  カウントダウン開始
            timeCount.enabled = false;                  //  表示を消す
        }
    }
}
