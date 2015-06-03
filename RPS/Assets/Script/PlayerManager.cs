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
    /// <summary>
    /// プレーヤーの手
    /// </summary>
	[SerializeField]
	private PlayerHand[] playerHand = null;
	/// <summary>
	/// ゲーム開始
	/// </summary>
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
    /// ゲーム終了
    /// </summary>
	public void EndGame()
	{
		for (var i = 0; i < playerHand.Length; i++) 
		{
			playerHand[i].EndGame();
		}
	}
    /// <summary>
    /// ボタンの押したタイミング
    /// </summary>
	public void GetPushHandTaimingu()
	{
		umpire.GetPlayerHand (handType);
	}
}
