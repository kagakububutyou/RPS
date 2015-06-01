using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
/// <summary>
/// ゲームスタート前のカウントダウン
/// </summary>
public class GameStartCountDown : MonoBehaviour {
    /// <summary>
    /// カウントダウンの表示
    /// </summary>
    [SerializeField]
    private Text timeCount = null;
    /// <summary>
    /// カウントダウンの初期値
    /// </summary>
    [SerializeField]
    private float startTime = 3.0f;
    /// <summary>
    /// カウントダウン
    /// </summary>
    private float timer = 0.0f;
    /// <summary>
    /// 条件
    /// </summary>
    private ConditioSelection conditioSelection = null;
    /// <summary>
    /// ゲームプレイ中のカウントダウン
    /// </summary>
    private GamePlayCount gamePlayCount = null;


	/// <summary>
	/// timerにタイムを代入
	/// </summary>
	private void Start () 
    {
        conditioSelection = GetComponent<ConditioSelection>();
        gamePlayCount = GetComponent<GamePlayCount>();
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
        if (timeCount.enabled == false) return;         //  カウントダウンをするかどうか

        timer -= Time.deltaTime;                        //  時間を減らす
        var temp = (int)timer;                          //  タイム表示のために小数点切り捨て
        if (timer >= 1.0f)                              //  1s以上なら
        {
            timeCount.text = "   " + temp.ToString();   //  数字をまんま表示
        }
        else if (timer < 1.0f)                          //  1s未満で
        {
			timeCount.text = "開始";                    //  Goを表示
        }
        if (timer <= 0.0f)                              //  0s以下で
        {
            conditioSelection.StartGame();              //  カウントダウンがゼロになったら呼ぶ
            gamePlayCount.StartGame();                  //  カウントダウン開始
            timeCount.enabled = false;                  //  表示を消す
        }
    }
}
