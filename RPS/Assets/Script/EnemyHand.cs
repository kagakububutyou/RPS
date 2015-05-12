using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
/// <summary>
/// 相手の手を決めるスクリプト
/// </summary>
public class EnemyHand : MonoBehaviour {

    [SerializeField]
    Text txt;
    private Umpire umpire;
    //string[] Hand = { "　 グー", "　 パー", "　 チョキ" };
	enum Hand
	{
		グー,
		パー,
		チョキ,
	};

    private int Hands = -1;

    // Use this for initialization
    void Start()
    {
		umpire = GetComponent<Umpire>();

        PushButton();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 何を出すか決めるところ
    /// </summary>
    public void PushButton()
    {
		var allData = Enum.GetValues (typeof(Hand));

        Hands = UnityEngine.Random.Range(0, 300);
        umpire.EnemyHand(Hands % allData.Length);
		var data = allData.GetValue (Hands % allData.Length);
		txt.text = data.ToString();

    }
}
