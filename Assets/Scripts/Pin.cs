using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	public UIManager ui;

	void Start () {
		ui = GameObject.FindWithTag ("UI").GetComponent<UIManager>();
	}
	
	void Update () {
		
	}

	void OnCollisionEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Pins") {
			ui.IncScore ();
			Destroy (gameObject);
		}
	}
}
