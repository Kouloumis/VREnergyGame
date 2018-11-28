using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;
	private Rigidbody rigidBody;

	// Use this for initialization
	void Start ()
	{
		rigidBody = GetComponent<Rigidbody> ();

	}

	void FixedUpdate()
	{

	// MOVEMENT ON THE X AXIS

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rigidBody.AddForce (movement * speed);

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
