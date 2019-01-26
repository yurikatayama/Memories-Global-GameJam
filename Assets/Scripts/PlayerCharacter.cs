using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

	private int age;
	private float jumpMultiplyer, speedMultiplyer, details, initialSpeed,
				  initialJump, speed, jump, moveLeft, infarto, stress,
				  canJump = 0f;
	float vert, hori;
	private Rigidbody2D rb;
	private bool jumping 		= true;
	private bool eventWrapper 	= false;
	private GameObject gameObj;
	
	// private float miopia;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		age = 1;
		infarto = 0.5f;
		stress = 10;
		moveLeft = 0.5f;
		speed = initialSpeed = 1;
		jump = initialJump = 5;
		AgeChanger (1);
		ScoreActions.ResetaContador();
	}
	
	// Update is called once per frame
	void Update () {
		//	Time.timeScale = age;

        vert = Input.GetAxisRaw("Vertical");
        hori = Input.GetAxis("Horizontal");

		PlayerActions.ContadorEvento();
		transform.Translate (-moveLeft * Time.deltaTime, 0, 0);
    }

	void FixedUpdate() {
        if(!jumping && !eventWrapper) {
			if (Time.time > canJump) {
				rb.velocity = new Vector2(hori * speed, vert * jump);
			} else {
				rb.velocity = new Vector2(hori * speed, 0);
			}
		} else if (jumping) {
			canJump = Time.time + 0.3f;
		}
		if (eventWrapper) {
			rb.velocity = new Vector2(0, 0);
			if (PlayerActions.contador == PlayerActions.maxEventCount) {
				Destroy(gameObj);
				setPombosConditions(false, false, 0);
			}
		}
		
		if (stress <= infarto) {
			Debug.Log("Infarto Fulminante");
			stress = 0;
			infarto = 0;
			Time.timeScale = 0;
		} else {
			stress = Random.Range (30f, 120f);
			infarto += 0.1f * Time.deltaTime;
		}

		if (Input.GetKeyDown(KeyCode.O) && age < 4) {
			age++;
			AgeChanger (age);
			Debug.Log ("Age: " + age);
		}
		if (Input.GetKeyDown(KeyCode.P) && age > 1) {
			age--;
			AgeChanger (age);
			Debug.Log ("Age: " + age);
		}
	}


	void AgeChanger (float playerAge) {
		
		Time.timeScale = playerAge * 1.5f;
		if (age == 1) {
            SetPlayerCharacter(2f, 0, 1);
        }
		if (age == 2) {
            SetPlayerCharacter(3f, 3f, 0.75f);
        }
		if (age == 3) {
            SetPlayerCharacter(4f, 3.5f, 0.5f);
        }
		if (age == 4) {
            SetPlayerCharacter(5f, 4f, 0.25f);
		}
	}

    void SetPlayerCharacter(float speedAux, float jumpAux, float detailsAux){
        speedMultiplyer = speedAux;
        jumpMultiplyer 	= jumpAux;
        details 		= detailsAux;
		
		speed			= initialSpeed * speedMultiplyer;
		jump 			= initialJump * jumpMultiplyer;
    }

	void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "ground") jumping = false;
    }

	void OnCollisionExit2D(Collision2D collision) {
		if (collision.gameObject.tag == "ground") jumping 			= true;
		if (collision.gameObject.tag == "Event Trap") eventWrapper 	= false;
	}

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Event Trap") {
			gameObj = collision.gameObject;
			setPombosConditions(true, true, 0);
		}
		if (collision.gameObject.tag == "Score") {
			ScoreActions.ContadorEvento();
			Destroy(collision.gameObject);
		}
	}

	void setPombosConditions(bool evWrp, bool boolPombos, int resetCounter) {
		eventWrapper 				= evWrp;
		PlayerActions.boolPombos 	= boolPombos;
		PlayerActions.contador	 	= resetCounter;
		
	}
}