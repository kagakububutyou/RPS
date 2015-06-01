using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// ボタンが押されたらゲーム終了
/// </summary>
public class GameEnd : MonoBehaviour {

    /// <summary>
    /// ボタンの取得
    /// </summary>
    [SerializeField]
    private Button button = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
        button.onClick.AddListener(PushButton);                    //  ボタンが押された時(イベントコールバック)
    }
    /// <summary>
    /// ボタンが押された時
    /// </summary>
    private void PushButton()
    {  
        Application.Quit();     //  ゲーム終了(アプリ起動時
    }
}
