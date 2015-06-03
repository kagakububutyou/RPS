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
    /// <summary>
    /// 条件の表示
    /// </summary>
    [SerializeField]
    private Text condition = null;
    /// <summary>
    /// ランダムのシード値に使う用。時間の取得
    /// </summary>
    private DateTime dtNow = DateTime.Now;
    /// <summary>
    /// 条件を一時保管
    /// </summary>
    private int conditioSelections = -1;
    /// <summary>
    /// 審判
    /// </summary>
	[SerializeField]
    private Umpire umpire = null;

    
    /// <summary>
    /// 勝敗条件
    /// </summary>
    /// [勝敗判定,不明,勝敗の渡す値]
    private string[, ,] Conditions =
    {
        {{"勝ってください","2",""},},
        {{"負けてください","1",""},},
    };

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
        UnityEngine.Random.seed = dtNow.Millisecond;    // ミリ秒を取得しシード値へ
        condition.enabled = false;                      //  条件の非表示
    }
    /// <summary>
    /// ゲーム開始時
    /// </summary>
	public void StartGame()
	{
		condition.enabled = true;                       //  条件の表示
		Conditio ();
	}
    /// <summary>
    /// 次のゲームへ
    /// </summary>
	public void NextGame()
	{
		Conditio ();
	}
    /// <summary>
    /// ゲーム終了時
    /// </summary>
	public void EndGame()
	{
		condition.enabled = false;                      //  条件の非表示
	}

    /// <summary>
    /// 条件を表示
    /// </summary>
    private void Conditio()
    {
        conditioSelections = UnityEngine.Random.Range(0,Conditions.Length /Conditions.Rank);    //  Handの数を取得
        umpire.GetConditio(Int32.Parse(Conditions[conditioSelections, 0, 1]));                  //  審判に条件を伝える
        condition.text = Conditions[conditioSelections, 0, 0];                                  //  出したてを表示する
    }
}
