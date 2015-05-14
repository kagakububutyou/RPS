using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
/// <summary>
/// 勝敗条件を決めるスクリプト
/// </summary>
public class ConditioSelection : MonoBehaviour {

    [SerializeField]
    private Text Condition = null;          //  条件を表示
	[SerializeField]
    private int RandomMax = 0;              //  乱数の最大値　意味あるのかな？
    private DateTime dtNow = DateTime.Now;  //  ランダムのシード値に使う用。時間の取得

    private int ConditioSelections = -1;    //  条件を一時保管

    //  勝敗条件
    // アップデート予定
    private enum Conditions
    {
        勝ってください,
        負けてください,
    };

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start() 
    {
        UnityEngine.Random.seed = dtNow.Millisecond;    // ミリ秒 (Millisecond) を取得しシード値へ
        Main();
	}
    /// <summary>
    /// 条件を表示
    /// </summary>
    public void Main()
    {
        var allData = Enum.GetValues(typeof(Conditions));                              //  Handの中の定数の値を取得
        ConditioSelections = UnityEngine.Random.Range(0, RandomMax * allData.Length);  //  Handの数を取得しランダムの最大値をかける
                                                                                       //  意味があるのかわからないので要検証
        var data = allData.GetValue(ConditioSelections % allData.Length);              //  何を出したかを代入
        Condition.text = data.ToString();                                              //  出したてを表示する
		Debug.Log (data.ToString ());                                                  //  デバック表示 
    }
}
