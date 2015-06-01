using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PlayerHand : IHand
{
    /// <summary>
    /// ボタン
    /// </summary>
    private Button button = null;
    /// <summary>
    /// プレイヤーのマネージャー
    /// </summary>
	private PlayerManager playerManager = null;
    /// <summary>
    /// 審判
    /// </summary>
	private Umpire umpire = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
		playerManager = GameObject.Find ("PlayerManager").GetComponent<PlayerManager> ();
		umpire = GameObject.Find ("Manager").GetComponent<Umpire> ();
        button = GetComponent<Button>();
        button.onClick.AddListener(PushHand);                   //  ボタンが押された時(イベントコールバック)
    }
    /// <summary>
    /// ボタンが押された時
    /// </summary>
    protected override void PushHand()
    {
        playerManager.GetPushHandTaimingu();
        umpire.Judgment();
    }
}
