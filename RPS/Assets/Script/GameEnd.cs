using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {

    [SerializeField]
    private Button button = null;	    //  ボタンの取得

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
        Application.Quit();
    }
}
