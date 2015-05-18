using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
/// <summary>
/// 場所の入れ替え
/// </summary>
public class PositionChange : MonoBehaviour {

    [SerializeField]
    private Button[] PlayerHand = null;     //  入れ替えるもの

    private DateTime dtNow = DateTime.Now;  //  ランダムのシード値に使う用。時間の取得



	// Use this for initialization
	void Start () 
    {
        UnityEngine.Random.seed = dtNow.Millisecond;    // ミリ秒 (Millisecond) を取得しシード値へ
	}

    /// <summary>
    /// 場所入れ替え
    /// </summary>
    public void Change()
    {
        for (int i = 0; i < PlayerHand.Length; i++)
        {
            int j = UnityEngine.Random.Range(0, PlayerHand.Length);
            Vector2 temp = PlayerHand[i].transform.position;
            PlayerHand[i].transform.position = PlayerHand[j].transform.position;
            PlayerHand[j].transform.position = temp;
        }
    }
}
