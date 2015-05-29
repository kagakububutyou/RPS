using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PlayerHand : MonoBehaviour
{
    [SerializeField]
    PlayerManager manager = null;

    [SerializeField]
    PlayerManager.HandType handType = PlayerManager.HandType.MaxValue;

    private Button button = null;	              	        //  ボタンの取得

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
        button = GetComponent<Button>();                        //  ボタンの取得
        button.onClick.AddListener(PushHand);                   //  ボタンが押された時(イベントコールバック)
    }

    /// <summary>
    /// ボタンを処理するか
    /// </summary>
    public void ChangeDrawMode(bool Mode)
    {
        //button.enabled = Mode;
    }
    /// <summary>
    /// なんのボタンが押されたか
    /// 基本的にボタンが押された時に
    /// 処理をする
    /// いずれ変更
    /// </summary>
    private void PushHand()
    {
        manager.GetPlayeHand(handType);
    }
}
