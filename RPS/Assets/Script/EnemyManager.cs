using UnityEngine;
using System.Collections;
/// <summary>
/// 敵のマネージャー
/// </summary>
public class EnemyManager : ICharacterHand{

    /// <summary>
    /// 審判
    /// </summary>
	[SerializeField]
	private Umpire umpire = null;
    /// <summary>
    /// 敵の手
    /// </summary>
	[SerializeField]
	private EnemyHand enemyHand = null;

    /// <summary>
    /// ボタンを押したタイミング
    /// </summary>
	public void GetPushHandTaimingu()
	{
		umpire.GetEnemyHand (handType);
	}
    /// <summary>
    /// ゲーム開始時
    /// </summary>
	public void StartGame()
	{
		enemyHand.StartGame ();
	}
    /// <summary>
    /// 次のゲームへ
    /// </summary>
	public void NextGame()
	{
		enemyHand.Reset ();
	}
    /// <summary>
    /// ゲーム終了
    /// </summary>
	public void EndGame()
	{
		enemyHand.EndGame ();
	}
    
}
