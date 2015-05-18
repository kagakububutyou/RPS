using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PlayerHand : MonoBehaviour
{

    [SerializeField]
    private Button button = null;	              	       //  ボタンの取得
    private EnemyHand enemyHand = null;                    //  敵の手
    private Umpire umpire = null;                          //  審判
    private ConditioSelection conditioSelection = null;    //  条件選択

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {

        enemyHand = GetComponent<EnemyHand>();                  //  敵の手のコンポーネントの取得
        conditioSelection = GetComponent<ConditioSelection>();  //  条件のコンポーネントの取得
        umpire = GetComponent<Umpire>();                        //  審判のコンポーネントの取得
        button.onClick.AddListener(ShowLog);                    //  ボタンが押された時(イベントコールバック)
    }
    /// <summary>
    /// なんのボタンが押されたか
    /// 基本的にボタンが押された時に
    /// 処理をする
    /// </summary>
    private void ShowLog()
    {
        umpire.GetPlayerHand(int.Parse(button.name));   //  審判に何を出したかを教える
        umpire.Judgment();                              //  勝敗判定
        enemyHand.PushButton();                         //  敵の次に出す手を選択
        conditioSelection.DrawConditio();               //  条件の表示
    }
}
