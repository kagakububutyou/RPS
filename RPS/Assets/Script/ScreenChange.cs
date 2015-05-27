using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押されたらシーン移動
/// </summary>
public class ScreenChange : MonoBehaviour {

    [SerializeField]
    private Button button = null;	    //  ボタンの取得

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
		//Application.LoadLevel(screen.name);         // シーン移動  
    }

	private void Reset()
	{
		Umpire.ExactlyCount = 0;
		Umpire.QuestionCount = 0;
	}
}
