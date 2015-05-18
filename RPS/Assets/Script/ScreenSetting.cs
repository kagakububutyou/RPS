using UnityEngine;
using System.Collections;

public class ScreenSetting : MonoBehaviour {

    [SerializeField]
    private int width  = 640;   //  横幅
    [SerializeField]
    private int height = 960;   //  縦幅
    [SerializeField]
    bool fullscreen = false;    //  フルスクリーンにするかどうか


    /// <summary>
    /// 解像度を固定
    /// </summary>
	void Start () 
    {
        Screen.SetResolution(width, height, fullscreen);	
	}
}
