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
			vert = Input.GetAxisRaw("Vertical");
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
            SetPlayerCharacter(1.5f, 0, 1);
        }
		if (age == 2) {
            SetPlayerCharacter(0.8f, 0.8f, 0.75f);
        }
		if (age == 3) {
            SetPlayerCharacter(1f, 1f, 0.5f);
        }
		if (age == 4) {
            SetPlayerCharacter(1.5f, 1.5f, 0.25f);
		}

	}

    void SetPlayerCharacter(float speedAux, float jumpAux, float detailsAux){
        speedMultiplyer = speedAux;
        jumpMultiplyer = jumpAux;
        details = detailsAux;
    }

	void OnCollisionEnter2D(Collision2D collision) {
		
		if (collision.gameObject.tag == "ground") {
			jumping = false;
		}
	}

	void OnCollisionExit2D(Collision2D collision) {
		
		if (collision.gameObject.tag == "ground") {
			jumping = true;
		}
	}
}
