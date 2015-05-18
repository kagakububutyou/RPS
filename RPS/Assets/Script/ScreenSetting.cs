using UnityEngine;
using System.Collections;

public class ScreenSetting : MonoBehaviour {

    [SerializeField]
    private int width  = 640;   //  横幅
    [SerializeField]
    private int height = 960;   //  縦幅
    [SerializeField]
    bool fullscreen = false;    //  フルスクリーンにするかどうか


	// Use this for initialization
	void Start () 
    {
        Screen.SetResolution(width, height, fullscreen);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
