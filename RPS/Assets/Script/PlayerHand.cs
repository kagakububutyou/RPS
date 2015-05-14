using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PlayerHand : MonoBehaviour {

    [SerializeField]
    private Button button = null;	              	//  ボタンの取得
	private EnemyHand enemyHand;                    //  敵の手
    private Umpire umpire;                          //  審判
	private ConditioSelection conditioSelection;    //  条件選択

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
		umpire = GetComponent<Umpire>();                        //  審判のコンポーネントの取得
		enemyHand = GetComponent<EnemyHand>();                  //  敵の手のコンポーネントの取得
		conditioSelection = GetComponent<ConditioSelection>();  //  条件のコンポーネントの取得
        button.onClick.AddListener(Main);                    //  ボタンが押された時(イベントコールバック)
    }
    /// <summary>
    /// なんのボタンが押されたか
    /// 基本的にボタンが押された時に
    /// 処理をする
    /// </summary>
    private void Main()
    {
        umpire.GetPlayerHand(int.Parse(button.name));   //  審判に何を出したかを教える
		umpire.Judgment();                              //  勝敗判定
		enemyHand.PushButton();                         //  敵の次に出す手を選択
		conditioSelection.Main ();                      //  条件の表示
    }
}
