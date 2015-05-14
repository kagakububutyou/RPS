using UnityEngine;
using System.Collections;
/// <summary>
/// 勝ち負けを決めるスクリプト
/// </summary>
public class Umpire : MonoBehaviour
{

    private int PlayerHands = 0;    //  プレイヤーの何を出したかを受け取る
    private int EnemyHands = 0;    //  敵が何を出したかを受け取る
    private int Conditios = 0;    //  勝敗条件を受け取る

    /// <summary>
    /// プレイヤーが何を出したかをもらう
    /// </summary>
    /// <param name="Hands">何出したか？</param>
    public void GetPlayerHand(int Hands)
    {
        PlayerHands = Hands;                //  情報を受け取る
        Debug.Log("自分" + PlayerHands);    //　デバック表示
    }
    /// <summary>
    /// 敵が何を出したかをもらう
    /// </summary>
    /// <param name="Hands">何を出したか？</param> 
    public void GetEnemyHand(int Hands)
    {
        EnemyHands = Hands;                 //  何を出してるかを受け取る
        Debug.Log("相手" + EnemyHands);     //  デバック表示
    }
    /// <summary>
    /// 勝敗条件をもらう
    /// </summary>
    /// <param name="Conditios">勝敗条件をもらう</param>
    public void GetConditio(int Conditios)
    {
        this.Conditios = Conditios;                 //  条件を受け取る
        Debug.Log("勝敗条件" + Conditios);          //  デバック表示
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
    ///     引き分けは同じ時、同じ値
    ///     勝利の場合
    ///     自分に2を加算後3で剰余した値が敵が同じ時
    ///     敗北の場合
    ///     自分に1を加算後3で剰余した値が敵と同じ時
    ///     ゆえに以下のようになる
    public void Judgment()
    {
        //  同じ値
        if (PlayerHands == EnemyHands)
        {
            Debug.Log("あいこ");
        }
        //  2を加算後３で剰余、敵と値が同じ
        else if ((PlayerHands + 2) % 3 == EnemyHands)
        {
            Debug.Log("勝利");
        }
        //  1を加算後3で剰余、敵と値が同じ
        else if ((PlayerHands + 1) % 3 == EnemyHands)
        {
            Debug.Log("敗北");
        }
    }

}
