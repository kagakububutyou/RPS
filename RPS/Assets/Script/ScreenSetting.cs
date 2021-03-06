﻿using UnityEngine;
using System.Collections;
/// <summary>
/// 解像度の固定
/// </summary>
public class ScreenSetting : MonoBehaviour {

    /// <summary>
    /// 横幅
    /// </summary>
    [SerializeField]
    private int width  = 640;
    /// <summary>
    /// 縦幅
    /// </summary>
    [SerializeField]
    private int height = 960;
    /// <summary>
    /// フルスクリーンにするかどうか
    /// </summary>
    [SerializeField]
    bool fullscreen = false;

    /// <summary>
    /// 解像度を固定
    /// </summary>
	void Start () 
    {
        Screen.SetResolution(width, height, fullscreen);	
	}
}
