using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
/// <summary>
/// 結果発表
/// </summary>
public class Result : MonoBehaviour {
    /// <summary>
    /// 得点表示
    /// </summary>
	[SerializeField]
	private Text result = null;
    /// <summary>
    /// 正解数表示
    /// </summary>
    [SerializeField]
    private Text exactly = null;
    /// <summary>
    /// 不正解数表示
    /// </summary>
    [SerializeField]
    private Text incorrect = null;
    /// <summary>
    /// 得点
    /// </summary>
    private int Score = 0;
    /// <summary>
    /// 正解数
    /// </summary>
    private int exactlyNum = 0;
    /// <summary>
    /// 不正解数
    /// </summary>
    private int incorrectNum = 0;
    /// <summary>
    /// 正解した時の得点
    /// </summary>
    [SerializeField]
    private int exactlyScore = 0;
    /// <summary>
    /// 不正解の時の得点
    /// </summary>
    [SerializeField]
    private int incorrectScore = 0;
    /// <summary>
    /// 右詰め最大値
    /// </summary>
    private int RightJustifiedMax = 25;

    /// <summary>
    /// スコアランキング
    /// </summary>
    [SerializeField]
    private ScoreRanking scoreRanking = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
	{
        exactlyNum = Umpire.exactlyCount;
        incorrectNum = Umpire.incorrectCount;

        Score = (exactlyNum * exactlyScore) - (incorrectNum * incorrectScore);
        scoreRanking.GetRanking();
        scoreRanking.SaveRanking(Score);
	}

    private void Update()
    {
        DarwResult();
    }

    /// <summary>
    /// 右詰め変換
    /// </summary>
    /// <returns>余白</returns>
    /// String.Formatだと思ったようにはならなかったため
    /// 自分で実装してみた
    private string RightJustified(int Number)
    {
        ///開けたい空白の数
        int whiteSpaceNum = RightJustifiedMax - Number.ToString().Length * 2;
        string whiteSpaceCount = "";

        for (int i = 0; i < whiteSpaceNum; i++)
        {
            whiteSpaceCount += " ";
        }

        return whiteSpaceCount + Number.ToString();
    }

    /// <summary>
    /// 結果の表示
    /// </summary>
	private void DarwResult()
	{
        exactly.text = RightJustified(exactlyNum);
        incorrect.text = RightJustified(incorrectNum);
        result.text = RightJustified(Score);
	}
}
