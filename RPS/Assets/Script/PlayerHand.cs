using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PlayerHand : IHand
{

    private Button button = null;	              	        //  ボタンの取得
	private PlayerManager playerManager = null;
	private Umpire umpire = null;


    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
		playerManager = GameObject.Find ("PlayerManager").GetComponent<PlayerManager> ();
		umpire = GameObject.Find ("Manager").GetComponent<Umpire> ();
        button = GetComponent<Button>();                        //  ボタンの取得
        button.onClick.AddListener(PushHand);                   //  ボタンが押された時(イベントコールバック)
		button.onClick.AddListener(playerManager.GetPushHandTaimingu);
		button.onClick.AddListener (umpire.Judgment);
    }

    /// <summary>
    /// ボタンを処理するか
    /// </summary>
    public void ChangeDrawMode(bool Mode)
    {
        //button.enabled = Mode;
    }
}
