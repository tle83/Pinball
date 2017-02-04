using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public static int score;
	GUIText text;

	void Awake()
	{
		text = GetComponent<GUIText> ();
		score = 0;
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + score;
	}
}
