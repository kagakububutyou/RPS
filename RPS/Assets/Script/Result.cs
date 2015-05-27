using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 結果発表
/// </summary>
public class Result : MonoBehaviour {

	[SerializeField]
	private Text result = null;

	private int Exactly = 0;
	private int Question = 0;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
	{
		Exactly = Umpire.ExactlyCount;
		Question = Umpire.QuestionCount;

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
