using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private int age;
	private float jump;
	private float speed;
	private float details;
	private Rigidbody rb;
	
	// private float miopia;
	// private float stress;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		AgeChanger (age);
		
	}

	void FixedUpdate() {
		CharacterController (speed);
		
	}

	void CharacterController (float pSpeed) {

			Debug.Log("Aconteceu");
			float direction = Input.GetAxis("Horizontal") * pSpeed;
			transform.Translate(0, 0, direction);

	}

	void AgeChanger (float playerAge) {
		
		if (age == 1) {
			speed = 50.5f;
			jump = 0;
			details = 1;

		}
		if (age == 2) {
			speed = 0.8f;
			jump = 0.8f;
			details = 0.75f;
		}
		if (age == 3) {
			speed = 1f;
			jump = 1;
			details = 0.5f;

		}
		if (age == 4) {
			speed = 1.5f;
			jump = 1.5f;
			details = 0.25f;
		}

	}
}
