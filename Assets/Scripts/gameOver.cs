using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour 
{
	public Text text;
	void Start()
	{
		text.text = "";
		text.color = Color.white;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		UnityEngine.Debug.Log ("Game Over");
		text.text = "Game Over";
	}
}
