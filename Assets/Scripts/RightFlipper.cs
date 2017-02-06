using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipper : MonoBehaviour 
{
	HingeJoint2D hinge;
	JointMotor2D jointMotor;

	void Start()
	{
		hinge = gameObject.GetComponent<HingeJoint2D> ();
		jointMotor = hinge.motor;
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.RightArrow)) {
			jointMotor.motorSpeed = -700;
		} else {
			jointMotor.motorSpeed = 700;
		}
		hinge.motor = jointMotor;

	}
}
