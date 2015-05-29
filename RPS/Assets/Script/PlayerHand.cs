using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押された時のスクリプト
/// </summary>
public class PlayerHand : IHand
{

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

}
