using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hoge : MonoBehaviour {

    Button button;

	// Use this for initialization
	void Start () 
    {

        button = GameObject.Find("Button").GetComponent<Button>();

        button.onClick.AddListener(ShowLog);	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void ShowLog()
    {
        Debug.Log("＼(^O^)／");
    }
}
