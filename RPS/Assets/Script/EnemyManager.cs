using UnityEngine;
using System.Collections;
/// <summary>
/// 敵のマネージャー
/// </summary>
public class EnemyManager : ICharacterHand{

    /// <summary>
    /// 審判
    /// </summary>
	private Umpire umpire = null;
    /// <summary>
    /// 敵の手
    /// </summary>
	private EnemyHand enemyHand = null;
	
	/// <summary>
	/// 初期化のためにこれを使用してください
	/// </summary>
	private void Start () 
	{
		umpire = GameObject.Find ("Manager").GetComponent<Umpire> ();
		enemyHand = GameObject.Find ("EnemyHand").GetComponent<EnemyHand> ();
	}
    /// <summary>
    /// ボタンを押したタイミング
    /// </summary>
	public void GetPushHandTaimingu()
	{
		umpire.GetEnemyHand ((int)handType);
	}
    /// <summary>
    /// 次のゲームへ
    /// </summary>
	public void NextGame()
	{
		enemyHand.Reset ();
	}
    
}
