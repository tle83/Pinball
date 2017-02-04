using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightFlipper : MonoBehaviour 
{
	HingeJoint2D hinge;
	public float force = 100f;
	Rigidbody2D flipper;

	void start()
	{
		hinge = gameObject.GetComponent<HingeJoint2D> ();
		flipper = gameObject.GetComponent<Rigidbody2D>();
	}

	void update()
	{
		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			hinge.useMotor = true;
			flipper.AddTorque (force);
		}
	}
}
