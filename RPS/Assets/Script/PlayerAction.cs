﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
/// <summary>
/// 場所の入れ替え
/// </summary>
public class PlayerAction : MonoBehaviour {

    /// <summary>
    /// 入れ替えるもの
    /// </summary>
    [SerializeField]
    private Button[] PlayerHand = null;
    /// <summary>
    /// ランダムのシード値に使う用。時間の取得
    /// </summary>
    private DateTime dtNow = DateTime.Now;  

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	void Start () 
    {
        UnityEngine.Random.seed = dtNow.Millisecond;    // ミリ秒 (Millisecond) を取得しシード値へ
	}

    /// <summary>
    /// 場所入れ替え
    /// </summary>
	public void PositionChange()
    {
        for (int i = 0; i < PlayerHand.Length; i++)
        {
            int j = UnityEngine.Random.Range(0, PlayerHand.Length);                 //  ランダムの幅を代入
            Vector2 temp = PlayerHand[i].transform.position;                        //  一時保管
            PlayerHand[i].transform.position = PlayerHand[j].transform.position;    //  適当なものを代入
            PlayerHand[j].transform.position = temp;                                //  一時保管を代入し直す
        }
    }
}
