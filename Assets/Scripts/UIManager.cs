using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	int score = 0;
	public Text scoreText;

	void Start(){
	}

	void Update(){
	}

	public void IncScore(){
		score += 20;
		scoreText.text = "Score: " + score;
	}

	void OnGUI(){
		GUI.Box (new Rect (10, 10, 200, 90), "SCORE: ");
	}
}
