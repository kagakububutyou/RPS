using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;

public class ConditioSelection : MonoBehaviour {

    [SerializeField]
    Text Condition;

    enum Conditions
    {
        勝ってください,
        負けてください,
    };

	// Use this for initialization
	void Start () 
    {
        DrawConditio();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void DrawConditio()
    {
        Condition.text = Conditions.勝ってください.ToString();
    }
}
