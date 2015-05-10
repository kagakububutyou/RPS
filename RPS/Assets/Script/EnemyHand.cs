using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 相手の手を決めるスクリプト
/// </summary>
public class EnemyHand : MonoBehaviour {

    [SerializeField]
    Text txt;
    private Umpire umpire;
    string[] Hand = { "　 グー", "　 パー", "　 チョキ" };

    private int Hands = -1;

    // Use this for initialization
    void Start()
    {
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
      
        Hands = UnityEngine.Random.Range(0, 300);
        umpire = GetComponent<Umpire>();
        umpire.EnemyHand(Hands % Hand.Length);
        txt.text = Hand[Hands % Hand.Length];

    }
}
