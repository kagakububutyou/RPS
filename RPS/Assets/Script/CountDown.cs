using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class CountDown : MonoBehaviour {

    [SerializeField]
    private Text timeCount = null;
    [SerializeField]
    private float startTime = 3.0f;
    private float timer = 0.0f;

	/// <summary>
	/// timerにタイムを代入
	/// </summary>
	private void Start () 
    {
        timer = startTime;
	}
	
	/// <summary>
	/// カウントダウン
	/// </summary>
    private	void Update () 
    {
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
            timeCount.enabled = false;                  //  表示を消す
        }
	}
}
