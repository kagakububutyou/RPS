using UnityEngine;
using System.Collections;
/// <summary>
/// 勝ち負けを決めるスクリプト
/// </summary>
public class Umpire : MonoBehaviour {

    private int PlayerHands = 0;
    private int EnemyHands = 0;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    public void PlayerHand(int Hands)
    {
        PlayerHands = Hands;
        Debug.Log("自分" + PlayerHands);
    }

    public void EnemyHand(int Hands)
    {
        EnemyHands = Hands;
        Debug.Log("相手" + EnemyHands);
    }

    public void Judgment()
    {
        if (PlayerHands == EnemyHands)
        {
            Debug.Log("あいこ");
        }
        else if ((PlayerHands + 2) % 3 == EnemyHands) 
        {
            Debug.Log("勝");
        }
        else if ((PlayerHands + 1) % 3 == EnemyHands)
        {
            Debug.Log("負");
        }
    }

}
