using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PlayerHand : MonoBehaviour {

    [SerializeField]
    Button button;		//	 

	private EnemyHand enemyHand;
    private Umpire umpire;
	private ConditioSelection conditioSelection;

    // Use this for initialization
    void Start()
    {
		umpire = GetComponent<Umpire>();
		enemyHand = GetComponent<EnemyHand>();
		conditioSelection = GetComponent<ConditioSelection>();
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
		enemyHand.PushButton();
		conditioSelection.DrawConditio ();
    }
}
