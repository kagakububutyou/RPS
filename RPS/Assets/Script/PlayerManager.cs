using UnityEngine;
using System.Collections;

public class PlayerManager : ICharacterHand {

	private Umpire umpire = null;
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
    /// 更新は、フレームごとに一度呼ばれています
    /// </summary>
	private void Update () 
    {

	}

	public void NextGame()
	{
		playerAction.PositionChange ();
	}

	public void GetPushHandTaimingu()
	{
		umpire.GetPlayerHand ((int)handType);
	}
}
