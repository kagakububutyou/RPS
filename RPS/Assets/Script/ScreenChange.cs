using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押されたらシーン移動
/// </summary>
public class ScreenChange : MonoBehaviour {

    /// <summary>
    /// ボタン
    /// </summary>
    [SerializeField]
    private Button button = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
    {
        button.onClick.AddListener(PushButton);     //  ボタンが押された時(イベントコールバック)
	}
    /// <summary>
    /// ボタンが押された時
    /// </summary>
    private void PushButton()
    {
		Reset();
        Application.LoadLevel("main");         // シーン移動  
    }
    /// <summary>
    /// リセット
    /// </summary>
	private void Reset()
	{
        Umpire.exactlyCount     = 0;
        Umpire.incorrectCount   = 0;
	}
}
