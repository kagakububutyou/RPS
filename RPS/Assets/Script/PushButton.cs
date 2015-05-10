using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PushButton : MonoBehaviour {

    [SerializeField]
    Button button;

    private EnemyHand txt;
    private Umpire umpire;

    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(ShowLog);
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// なんのボタンが押されたか
    /// </summary>
    void ShowLog()
    {

        umpire = GetComponent<Umpire>();
        umpire.PlayerHand(int.Parse(button.name));
        umpire.Judgment();
        txt = GetComponent<EnemyHand>();
        txt.PushButton();
    }
}
