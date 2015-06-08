using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// 画面タッチ
/// </summary>
public class TouchScreen : MonoBehaviour {

    [SerializeField]
    private Canvas image = null;

	// Use this for initialization
	private void Start () 
    {
	
	}
	
	// Update is called once per frame
	private void Update () 
    {
        TouchPos();

        //Destroy(this, 0.5f);
	}

    private void TouchPos()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(image);
        }
    }
}
