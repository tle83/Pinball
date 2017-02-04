using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher : MonoBehaviour 
{
	Rigidbody2D rigidBody;
	Vector2 currentPos;
	Vector2 inititalPos;

	void Start () 
	{
		rigidBody = gameObject.GetComponent<Rigidbody2D> ();
		inititalPos = gameObject.transform.position;
	}

	void Update ()
	{
		currentPos = inititalPos;
		if (Input.GetKeyDown (KeyCode.Return)) {
			currentPos.y = inititalPos.y + .2f;
			rigidBody.MovePosition (currentPos);
		}
		if (currentPos.y == inititalPos.y + .2f) {
			rigidBody.MovePosition (inititalPos);
		}
	}
}
