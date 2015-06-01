using UnityEngine;
using System.Collections;

public class EnemyManager : ICharacterHand{

	private Umpire umpire = null;
	
	/// <summary>
	/// 初期化のためにこれを使用してください
	/// </summary>
	private void Start () 
	{
		umpire = GameObject.Find ("Manager").GetComponent<Umpire> ();
	}

    /// <summary>
    /// 更新は、フレームごとに一度呼ばれています
    /// </summary>
    private void Update()
    {

    }

	public void GetPushHandTaimingu()
	{
		umpire.GetEnemyHand ((int)handType);
	}

    
}
