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
    private Text Condition = null;          //  条件を表示
    private DateTime dtNow = DateTime.Now;  //  ランダムのシード値に使う用。時間の取得
    private int ConditioSelections = -1;    //  条件を一時保管
    private Umpire umpire = null;           //  審判

    //[勝敗判定,不明,勝敗の渡す値]
    private string[, ,] Conditions =
    {
        {{"勝ってください","2","-1"},},
        {{"負けてください","1","-1"},},
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
        ConditioSelections = UnityEngine.Random.Range(0,Conditions.Length /Conditions.Rank);    //  Handの数を取得
        umpire.GetConditio(Int32.Parse(Conditions[ConditioSelections, 0, 1]));                  //  審判に条件を伝える
        Condition.text = Conditions[ConditioSelections, 0, 0];                                  //  出したてを表示する
        
    }
}
