using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

	private int age, tipoTrap;
	private float jumpMultiplyer, speedMultiplyer, details, speed, jump, stress, infarto;
	float vert, hori;
	private Rigidbody2D rb;
<<<<<<< HEAD
	public float speed;
	public float jump;

	private float moveLeft;

	private bool jumping 		= true;
	private bool eventWrapper 	= false;
=======
	private bool jumping 		= true,
				 eventWrapper 	= false;
>>>>>>> 256f8d20cd4ece3852e3848255cb9402f8a7debb
	private GameObject gameObj;
	// private float miopia;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		age = 3;
		infarto = 0.5f;
		stress = 10;
<<<<<<< HEAD
		moveLeft = 0.5f;
=======
		tipoTrap = Random.Range(1, 6);
		instanciaEvento(0, tipoTrap);
>>>>>>> 256f8d20cd4ece3852e3848255cb9402f8a7debb
	}
	
	// Update is called once per frame
	void Update () {

		AgeChanger (age);
		
		speed *= speedMultiplyer;
		jump *= jumpMultiplyer;

        vert = Input.GetAxisRaw("Vertical");
        hori = Input.GetAxisRaw("Horizontal");

		PlayerActions.ContadorEvento(tipoTrap);
    }

	void FixedUpdate() {
        if(!jumping && !eventWrapper) {
			rb.velocity = new Vector2(hori * speed, vert * jump);
		}
		if (eventWrapper) {
			rb.velocity = new Vector2(0, 0);
			if (PlayerActions.contador == PlayerActions.maxEventCount) {
				Destroy(gameObj);
			}
		}
		

		if (stress <= infarto) {
			Debug.Log("Infarto Fulminante");
			stress = 0;
			infarto = 0;
			Time.timeScale = 0;
		} else {
			stress = Random.Range (30f, 100f);
			infarto += 1 * Time.deltaTime;
		}

		transform.Translate (-moveLeft * Time.deltaTime, 0, 0);
	}


	void AgeChanger (float playerAge) {
		
		Time.timeScale = age;
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
        jumpMultiplyer 	= jumpAux;
        details 		= detailsAux;
    }

	void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "ground") jumping = false;
    }

	void OnCollisionExit2D(Collision2D collision) {
		if (collision.gameObject.tag == "ground") jumping = true;
		if (collision.gameObject.tag == "Event Trap") eventWrapper = false;
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Event Trap") {
			gameObj = collision.gameObject;
			eventWrapper = true;
		}
	}

	void instanciaEvento(int resetCounter, int intTrap) {
		PlayerActions.intTrap 	= intTrap;
		PlayerActions.contador	 	= resetCounter;
		PlayerActions.maxEventCount = Random.Range(12, 25);
	}
}
