using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;

public class ConditioSelection : MonoBehaviour {

    [SerializeField]
    Text Condition;
	[SerializeField]
	int RandomMax = 0;

	int ConditioSelections = -1;

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

    public void DrawConditio()
    {
		var allData = Enum.GetValues (typeof(Conditions));
		ConditioSelections = UnityEngine.Random.Range (0, RandomMax * allData.Length);
		var data = allData.GetValue (ConditioSelections % allData.Length);

		Condition.text = data.ToString();
		Debug.Log (data.ToString ());
    }
}
