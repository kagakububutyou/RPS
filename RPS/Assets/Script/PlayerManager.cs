using UnityEngine;
using System.Collections;

public class PlayerManager : ICharacterHand {

    HandType handType = HandType.MaxValue;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
	private void Start () 
    {
	
	}

    /// <summary>
    /// 更新は、フレームごとに一度呼ばれています
    /// </summary>
	private void Update () 
    {
	
	}

    /// <summary>
    /// プレーヤーの手をもらってくる
    /// </summary>
    public void GetPlayeHand(HandType type)
    {
        handType = type;
        Debug.Log(handType.ToString());
    }
}
