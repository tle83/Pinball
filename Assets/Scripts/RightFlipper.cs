using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipper : MonoBehaviour 
{
	HingeJoint2D hinge;
	private float minAngle;
	private float maxAngle;

	void start()
	{
		hinge = gameObject.GetComponent<HingeJoint2D> ();
		minAngle = hinge.limits.min;
		maxAngle = hinge.limits.max;

	}

	void update()
	{
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			maxAngle = 180; //upper angle
			minAngle = 90;	//lower angle
		}
	}
}
