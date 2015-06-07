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
    /// <summary>
    /// 再生
    /// </summary>
    private AudioSource exactlySE = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	void Start () 
    {
        exactlySE = gameObject.GetComponent<AudioSource>();
        exactlySE.clip = exactly;
	}

    /// <summary>
    /// 正解音
    /// </summary>
    public void Exactly()
    {
        exactlySE.PlayOneShot(exactly);
    }
}
