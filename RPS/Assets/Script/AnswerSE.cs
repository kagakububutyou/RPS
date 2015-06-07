using UnityEngine;
using System.Collections;
/// <summary>
/// 効果音
/// </summary>
public class AnswerSE : MonoBehaviour {
    /// <summary>
    /// 正解音
    /// </summary>
    [SerializeField]
    private AudioClip exactly  = null;
	[SerializeField]
	private AudioClip mistake = null;
    /// <summary>
    /// 再生
    /// </summary>
    private AudioSource exactlySE = null;
	private AudioSource mistakeSE = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	void Start () 
    {
        exactlySE = gameObject.GetComponent<AudioSource>();
        exactlySE.clip = exactly;

		mistakeSE = gameObject.GetComponent<AudioSource> ();
		mistakeSE.clip = mistake;
	}

    /// <summary>
    /// 正解音
    /// </summary>
    public void Exactly()
    {
        exactlySE.PlayOneShot(exactly);
    }
	public void Mistake()
	{
		mistakeSE.PlayOneShot (mistake);
	}
}
