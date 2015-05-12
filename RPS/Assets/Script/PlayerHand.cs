using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PlayerHand : MonoBehaviour {

    [SerializeField]
    Button button;

    private EnemyHand txt;
    private Umpire umpire;

    // Use this for initialization
    void Start()
    {
		umpire = GetComponent<Umpire>();
		txt = GetComponent<EnemyHand>();
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

        
        umpire.PlayerHand(int.Parse(button.name));
        umpire.Judgment();
        txt.PushButton();
    }
}
