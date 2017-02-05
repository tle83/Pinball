using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour 
{
	public Text text;
	void Start()
	{
		text.text = "";
		text.color = Color.white;
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene ("Pinball Game");
		}
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		text.text = "Game Over";
	}
}
