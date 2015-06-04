using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VictoryOrDefeat : MonoBehaviour {

	[SerializeField]
	private Text answer = null;

	// Use this for initialization
	private void Start () 
	{
		answer.text = "";
		answer.enabled = false;
	}

	public void StartGame()
	{
		answer.enabled = true;
	}
	public void EndGame()
	{
		answer.enabled = false;
	}
	public void  Answer(string answer)
	{
		this.answer.text = answer;
	}
	private void FadeOut()
	{
		//answer
	}
}
