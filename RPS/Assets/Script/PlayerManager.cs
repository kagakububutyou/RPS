using UnityEngine;
using System.Collections;
/// <summary>
/// プレイヤーのマネージャー
/// </summary>
public class PlayerManager : ICharacterHand {
    /// <summary>
    /// 審判
    /// </summary>
	private Umpire umpire = null;
    /// <summary>
    /// プレイヤーのアクション
    /// </summary>
	private PlayerAction playerAction = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
    {
		umpire = GameObject.Find ("Manager").GetComponent<Umpire> ();
		playerAction = GetComponent<PlayerAction> ();
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
