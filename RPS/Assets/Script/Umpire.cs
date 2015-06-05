using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 勝ち負けを決めるスクリプト
/// </summary>
public class Umpire : MonoBehaviour
{
    /// <summary>
    /// プレイヤーの手
    /// </summary>
    private int playerHands = 0;
    /// <summary>
    /// 敵の手
    /// </summary>
    private int enemyHands = 0;
    /// <summary>
    /// 勝敗条件
    /// </summary>
    private int conditios = 0;
    /// <summary>
    /// 正解数
    /// </summary>
	public static int exactlyCount = 0;
    /// <summary>
    /// 問題数
    /// </summary>
	public static int questionCount = 0;
    /// <summary>
    /// プレイヤーマネージャー
    /// </summary>
	[SerializeField]
	private PlayerManager playerManager = null;
    /// <summary>
    /// 敵のマネージャー
    /// </summary>
	[SerializeField]
	private EnemyManager enemyManager = null;
    /// <summary>
    /// 勝敗条件
    /// </summary>
	[SerializeField]
    private ConditioSelection conditioSelection = null;
    /// <summary>
    /// プレイ中のカウントダウンの
    /// </summary>
	[SerializeField]
	private GamePlayCount gamePlayCount = null;
	[SerializeField]
	private VictoryOrDefeat victoryOrDefeat = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
		//victoryOrDefeat.text = "";      /// 中身を空にする
    }
    /// <summary>
    /// プレイヤーが何を出したかをもらう
    /// </summary>
    /// <param name="Hands">何出したか？</param>
	public void GetPlayerHand(ICharacterHand.HandType Hands)
    {
        playerHands = (int)Hands;                //  情報を受け取る
		Debug.Log("自分" + playerHands);    //　デバック表示
    }
    /// <summary>
    /// 敵が何を出したかをもらう
    /// </summary>
    /// <param name="Hands">何を出したか？</param> 
	public void GetEnemyHand(ICharacterHand.HandType Hands)
    {
        enemyHands = (int)Hands;                 //  何を出してるかを受け取る
		Debug.Log("相手" + enemyHands);     //  デバック表示
    }
    /// <summary>
    /// 勝敗条件をもらう
    /// </summary>
    /// <param name="Conditios">勝敗条件をもらう</param>
    public void GetConditio(int Conditios)
    {
        conditios = Conditios;                       //  条件を受け取る
        Debug.Log("勝敗条件" + conditios);           //  デバック表示
    }

    /// <summary>
    /// 審判
    /// </summary>
    public void Judgment()
    {
		enemyManager.GetPushHandTaimingu ();
		Judge ();
		NextGame ();
    }
    /// <summary>
    /// ゲーム開始
    /// </summary>
	public void StartGame()
	{
		playerManager.StartGame ();
		enemyManager.StartGame ();
		conditioSelection.StartGame();
		gamePlayCount.StartGame();
		victoryOrDefeat.StartGame ();
	}

    /// <summary>
    /// 次のゲームへ
    /// </summary>
	private void NextGame()
	{
		playerManager.NextGame ();
		enemyManager.NextGame ();
        conditioSelection.NextGame();
	}
    /// <summary>
    /// ゲーム終了
    /// </summary>
	public void EndGame()
	{
		playerManager.EndGame ();
		enemyManager.EndGame ();
		conditioSelection.EndGame();
		victoryOrDefeat.EndGame ();
	}

	/// <summary>
	/// じゃんけんの勝敗判定
	/// </summary>
	/// 
	/// ０はグー
	/// １はパー
	/// ２はチョキ
	/// ○は勝利
	/// △は引き分け(あいこ)
	/// ×は敗北
	/// とする
	///
	///         勝敗表
	///             て き
	///    　　｜０｜１｜２
	///  じ  ０｜△｜×｜○
	///  ぶ  １｜○｜△｜×
	///  ん  ２｜×｜○｜△
	///         勝敗パターン
	///     勝利       敗北
	///     ０－２     ０－１
	///     １－０     １－２
	///     ２－１     ２－０
	///     引き分けの場合
	///     同じ値
	///     勝利の場合
	///     自分に2を加算後3で剰余した値が敵が同じ時
	///     敗北の場合
	///     自分に1を加算後3で剰余した値が敵と同じ時
	///     自分の値に条件を加算し0になれば引き分け
    ///     
	private void Judge()
	{
		if ((playerHands + conditios) % 3 - enemyHands == 0) 
		{
			victoryOrDefeat.GetAnswer("正解");
			exactlyCount +=1;
			questionCount += 1;
			Debug.Log("正解");
		}
		else
		{
			victoryOrDefeat.GetAnswer("不正解");
			questionCount += 1;
			Debug.Log("不正解");
		}
	}
}
