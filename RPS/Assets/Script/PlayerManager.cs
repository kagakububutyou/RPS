using UnityEngine;
using System.Collections;
/// <summary>
/// プレイヤーのマネージャー
/// </summary>
public class PlayerManager : ICharacterHand {
    /// <summary>
    /// 審判
    /// </summary>
	[SerializeField]
	private Umpire umpire = null;
    /// <summary>
    /// プレイヤーのアクション
    /// </summary>
	[SerializeField]
	private PlayerAction playerAction = null;

	[SerializeField]
	private PlayerHand[] playerHand = null;
	
	public void StartGame()
	{
		for (var i = 0; i < playerHand.Length; i++) 
		{
			playerHand[i].StartGame();	
		}
	}

    /// <summary>
    /// 次のゲームへ
    /// </summary>
	public void NextGame()
	{
		playerAction.PositionChange ();
	}
    /// <summary>
    /// ボタンの押したタイミング
    /// </summary>
	public void GetPushHandTaimingu()
	{
		umpire.GetPlayerHand ((int)handType);
	}
}
