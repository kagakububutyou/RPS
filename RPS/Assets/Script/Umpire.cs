using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 勝ち負けを決めるスクリプト
/// </summary>
public class Umpire : MonoBehaviour
{

    private int GetPlayerHands = 0;     //  プレイヤーの何を出したかを受け取る
    private int GetEnemyHands = 0;      //  敵が何を出したかを受け取る
    private int GetConditios = 0;       //  勝敗条件を受け取る
    [SerializeField]
    private Text VictoryOrDefeat = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    void Start()
    {

        VictoryOrDefeat.text = "";      /// 中身を空にする
    }

    /// <summary>
    /// プレイヤーが何を出したかをもらう
    /// </summary>
    /// <param name="Hands">何出したか？</param>
    public void GetPlayerHand(int Hands)
    {
        GetPlayerHands = Hands;                //  情報を受け取る
        Debug.Log("自分" + GetPlayerHands);    //　デバック表示
    }
    /// <summary>
    /// 敵が何を出したかをもらう
    /// </summary>
    /// <param name="Hands">何を出したか？</param> 
    public void GetEnemyHand(int Hands)
    {
        GetEnemyHands = Hands;                 //  何を出してるかを受け取る
        Debug.Log("相手" + GetEnemyHands);     //  デバック表示
    }
    /// <summary>
    /// 勝敗条件をもらう
    /// </summary>
    /// <param name="Conditios">勝敗条件をもらう</param>
    public void GetConditio(int Conditios)
    {
        GetConditios = Conditios;                       //  条件を受け取る
        Debug.Log("勝敗条件" + GetConditios);           //  デバック表示
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
    ///     自分の値に条件を加算し0になれば正解

    public void Judgment()
    {
        if ((GetPlayerHands + GetConditios) % 3 - GetEnemyHands == 0) 
        {
            VictoryOrDefeat.text = "正解";
            Debug.Log("正解");
        }
        else
        {
            VictoryOrDefeat.text = "不正解";
            Debug.Log("不正解");
        }

    }

}
