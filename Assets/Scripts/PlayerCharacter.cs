using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

	private int age;
	private float jumpMultiplyer;
	private float speedMultiplyer;
	private float details;
	private Rigidbody2D rb;
	public float speed;
	public float jump;

	private bool jumping = true;

	float vert;
	float hori;
	
	// private float miopia;
	// private float stress;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		age = 3;

	}
	
	// Update is called once per frame
	void Update () {

		AgeChanger (age);
		
		speed *= speedMultiplyer;
		jump *= jumpMultiplyer;

		
		if (jumping == true) {
			vert = 0;
			Debug.Log ("Voando");
		} else {
			//vert = Input.GetAxisRaw("Vertical");
			rb.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
			Debug.Log ("Pulou");
			jumping = true;
		}
		hori = Input.GetAxisRaw("Horizontal");

	}

	void FixedUpdate() {

		rb.velocity = new Vector2(hori * speed, vert * jump);
		
	}


	void AgeChanger (float playerAge) {
		
		if (age == 1) {
			speedMultiplyer = 1.5f;
			jumpMultiplyer = 0;
			details = 1;
		}
		if (age == 2) {
			speedMultiplyer = 0.8f;
			jumpMultiplyer = 0.8f;
			details = 0.75f;
		}
		if (age == 3) {
			speedMultiplyer = 1f;
			jumpMultiplyer = 1;
			details = 0.5f;

		}
		if (age == 4) {
			speedMultiplyer = 1.5f;
			jumpMultiplyer = 1.5f;
			details = 0.25f;
		}

	}

	void OnCollisionEnter2D(Collision2D collision) {
		
		if (collision.gameObject.tag == "ground") {
			jumping = false;
			Debug.Log("Encostou");
		}
	}
}
