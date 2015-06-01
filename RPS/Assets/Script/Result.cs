using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 結果発表
/// </summary>
public class Result : MonoBehaviour {
    /// <summary>
    /// 結果表示
    /// </summary>
	[SerializeField]
	private Text result = null;
    /// <summary>
    /// 正解数
    /// </summary>
	private int Exactly = 0;
    /// <summary>
    /// 問題数
    /// </summary>
	private int Question = 0;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
	{
		Exactly = Umpire.exactlyCount;
		Question = Umpire.questionCount;

        DarwResult();
	}
    /// <summary>
    /// 結果の表示
    /// </summary>
	private void DarwResult()
	{
		result.text = "      " + Exactly.ToString() + "/" + Question.ToString() + "正解";
	}


}
