using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour 
{
	private int count;
	public Text countText;

	void Start()
	{
		count = 0;
		SetCountText ();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.CompareTag("Pins"))
		{
			count += 10;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Score: " + count.ToString ();
	}

}
