using UnityEngine;
using System.Collections;

public class ICharacterHand : MonoBehaviour {

    //  じゃんけんの手
    public enum HandType
    {
        Rock,           //  グー
        Paper,          //  パー
        Sciccors,       //  チョキ

        MaxValue,
    };

    private HandType handType = HandType.MaxValue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// プレーヤーの手をもらってくる
    /// </summary>
    public void GetHand(HandType type)
    {
        handType = type;
        Debug.Log(handType.ToString());
    }
}
