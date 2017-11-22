using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour {

	public float acceleration = 0.3f;
	public float braking = 0.3f;
	public float steering = 4.0f;

	// Use this for initialization
	void Start () {
		
	}

	// update for physics
	void FixedUpdate() {
		// steering
		float lSteering = 0;
		float lAcceleration = 0;
		if (Input.GetKey (KeyCode.UpArrow)) lAcceleration++;
		if (Input.GetKey (KeyCode.DownArrow)) lAcceleration--;
		if (Input.GetKey (KeyCode.RightArrow)) lSteering++;
		if (Input.GetKey (KeyCode.LeftArrow)) lSteering--;

		GetComponent<Rigidbody2D>().AddTorque(lSteering * steering * -0.2f);

		// apply car movement
		GetComponent<Rigidbody2D>().AddForce(transform.up * lAcceleration * acceleration * 50.0f);
		//GetComponent<Rigidbody2D>().AddForce(transform.right * lSteering * acceleration * 50.0f);

	}
}
