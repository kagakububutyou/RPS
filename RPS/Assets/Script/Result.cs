using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {

	[SerializeField]
	private Text result = null;

	private int Exactly = 0;
	private int Question = 0;

	// Use this for initialization
	private void Start () 
	{
		Exactly = Umpire.ExactlyCount;
		Question = Umpire.QuestionCount;
	}
	
	// Update is called once per frame
	private void Update () 
	{
		DarwResult ();
	}

	private void DarwResult()
	{
		result.text = "      " + Exactly.ToString() + "/" + Question.ToString() + "正解";
	}


}
