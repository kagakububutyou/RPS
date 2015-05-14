﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
/// <summary>
/// 相手の手を決めるスクリプト
/// </summary>
public class EnemyHand : MonoBehaviour {

    [SerializeField]
    private Text EnemyHands = null;         //  テキスト表示
	[SerializeField]
    private int RandomMax = 0;              //  ランダムの最大値を決める
    private DateTime dtNow = DateTime.Now;  //  ランダムのシード値に使う用。時間の取得
    private Umpire umpire;                  //  審判
    //  じゃんけんの手
	private enum Hand
	{
		グー,
		パー,
		チョキ,
	};

    private int Hands = -1;                 //  出す予定の値を一時保管

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
        UnityEngine.Random.seed = dtNow.Millisecond;    // ミリ秒 (Millisecond) を取得しシード値へ
        umpire = GetComponent<Umpire>();                //  審判のコンポーネントの取得
        PushButton();                                   //  初めに相手が何を出すかを決める
    }

    /// <summary>
    /// 何を出すか決めるところ
    /// </summary>
    public void PushButton()
    {
		var allData = Enum.GetValues (typeof(Hand));                        //  Handの中の定数の値を取得
		Hands = UnityEngine.Random.Range(0, RandomMax * allData.Length);    //  Handの数を取得しランダムの最大値をかける
                                                                            //  意味があるのかわからないので要検証
        umpire.GetEnemyHand(Hands % allData.Length);                        //  審判に何を出したかを教えてあげる
                                                                            //  上のお陰でHandの数で除算するはめに
		var data = allData.GetValue (Hands % allData.Length);               //  何を出したかを代入
        EnemyHands.text = data.ToString();                                  //  出したてを表示する

    }
}
