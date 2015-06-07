using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 答えの表示
/// </summary>
public class VictoryOrDefeat : MonoBehaviour {

    /// <summary>
    /// 答え
    /// </summary>
	[SerializeField]
	private Text answer = null;

    /// <summary>
    /// フェード中の透明度
    /// </summary>
    private float fadeAlpha = 1.0f;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
	{
		answer.text = "";
		answer.enabled = false;
	}
    private void Update()
    {
        DrawAnswer();
    }
    /// <summary>
    /// ゲーム開始
    /// </summary>
	public void StartGame()
	{
		answer.enabled = true;
	}
    /// <summary>
    /// ゲーム終了
    /// </summary>
	public void EndGame()
	{
		answer.enabled = false;
	}
    /// <summary>
    /// 正解か不正解を受けとる
    /// </summary>
    /// <param name="answer">答え</param>
	public void  GetAnswer(string answer)
	{
		this.answer.text = answer;
        StartCoroutine(FadeOut(1.0f));
	}

    /// <summary>
    /// フェードアウト用コルーチン
    /// </summary>
    /// <param name='interval'>かかる時間(秒)</param>
    private IEnumerator FadeOut(float interval)
    {
        float time = 0;
        while (time <= interval)
        {
            fadeAlpha = Mathf.Lerp(1.0f, 0.0f, time / interval);
            time += Time.deltaTime;
            yield return 0;
        }
    }
    /// <summary>
    /// 答えの表示
    /// </summary>
    private void DrawAnswer()
    {
        answer.color = new Vector4(0,0,0,fadeAlpha);
    }
}
