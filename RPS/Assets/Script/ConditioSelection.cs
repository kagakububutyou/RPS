using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
/// <summary>
/// 勝敗条件を決めるスクリプト
/// </summary>
public class ConditioSelection : MonoBehaviour
{

    [SerializeField]
    private Text Condition;          //  条件を表示
    private DateTime dtNow = DateTime.Now;  //  ランダムのシード値に使う用。時間の取得
    private int ConditioSelections = -1;    //  条件を一時保管
    Umpire umpire;                  //  審判

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
        umpire = GetComponent<Umpire>();                //  審判のコンポーネントの取得
        DrawConditio();
    }
    /// <summary>
    /// 条件を表示
    /// </summary>
    public void DrawConditio()
    {
        var allData = Enum.GetValues(typeof(Conditions));                 //  Handの中の定数の値を取得
        ConditioSelections = UnityEngine.Random.Range(0, allData.Length);  //  Handの数を取得
        var data = allData.GetValue(ConditioSelections);                  //  何を出したかを代入
        umpire.GetConditio(ConditioSelections);                           //  審判に条件を伝える
        Condition.text = data.ToString();                                 //  出したてを表示する
    }
}
