using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipper : MonoBehaviour 
{
	Rigidbody2D lFlipper;
	Rigidbody2D rFlipper;

	public float strength = 30000;
	public float sustain = 10000;

	void start(){
		lFlipper = transform.GetChild (1).GetComponent<Rigidbody2D> ();
		rFlipper = transform.GetChild (0).GetComponent<Rigidbody2D> ();
	}

	void update(){
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			rFlipper.AddTorque (-strength);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			lFlipper.AddTorque (strength);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			lFlipper.AddTorque (sustain);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rFlipper.AddTorque (-sustain);
		}
	}
}
