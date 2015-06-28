using UnityEngine;
using System.Collections;

public class touch: MonoBehaviour
{
    public GameObject sprite = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(sprite, new Vector3(10, 0, 0), Quaternion.identity);

        }
	}
}
