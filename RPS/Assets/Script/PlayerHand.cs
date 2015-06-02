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
	[SerializeField]
    private Button button = null;
    /// <summary>
    /// プレイヤーのマネージャー
    /// </summary>
	[SerializeField]
	private PlayerManager playerManager = null;
    /// <summary>
    /// 審判
    /// </summary>
	[SerializeField]
	private Umpire umpire = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
        button.onClick.AddListener(PushHand);                   //  ボタンが押された時(イベントコールバック)
		button.enabled = false;
    }

	public void StartGame()
	{
		button.enabled = true;
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
