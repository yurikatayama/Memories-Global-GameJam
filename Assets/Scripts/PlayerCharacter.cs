using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour {

	private int age, contadorFasesDavida;
	private float jumpMultiplyer, speedMultiplyer, details, initialSpeed,
				  initialJump, speed, jump, moveLeft, infarto, stress,
				  canJump = 0f;

	private float timerScore;
	private int scoreTime;

	float vert, hori;
	private Rigidbody2D rb;
	private bool jumping 		= true;
	private bool eventWrapper 	= false;
	private bool esposa = false, diploma = false, guitarra = false, mae = false;
	private GameObject gameObj;
	public List<GameObject> Sound;
	
	public bool superPlayer = false;

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
		contadorFasesDavida = 0;
		Sound[0].SetActive(true);
		timerScore = 20;
	}
	
	// Update is called once per frame
	void Update () {

        vert = Input.GetAxisRaw("Vertical");
        hori = Input.GetAxis("Horizontal");

		PlayerActions.ContadorEvento();
		transform.Translate (-moveLeft * Time.deltaTime, 0, 0);

		if (eventWrapper && timerScore >= 0) {
			timerScore -= 1 * Time.deltaTime;
			scoreTime = (int) timerScore;
			Debug.Log ("Tempo: " + scoreTime);
		} else {
			ScoreActions.contador += scoreTime;
			scoreTime = 0;
			timerScore = 20;

		}

		if (superPlayer) {
			age = 4;
		}
    }

	void FixedUpdate() {
		AgeChanger (age);
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
		if (PlayerActions.gameOverCond) {
			moveLeft = 0;
		}
		
		if (!superPlayer) {
			if (stress <= infarto) {
				Debug.Log("Infarto Fulminante");
				stress = 0;
				infarto = 0;
				PlayerActions.gameOverCond = true;
				Invoke ("GameOverCondition", 4);
			} else {
				stress = Random.Range (0f, 10000f);
				if (infarto < 100) {
					infarto += 0.05f * Time.deltaTime;
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.O) && age <= 4) {
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

	void GameOverCondition () {
			SceneManager.LoadScene(2);
	}


	void AgeChanger (float playerAge) {
		
		Time.timeScale = playerAge * 1.5f;
		if (age == 1) {
            SetPlayerCharacter(2f, 1f, 1);
        }
		if (age == 2) {
            SetPlayerCharacter(3f, 3f, 0.75f);
        }
		if (age == 3) {
            SetPlayerCharacter(4f, 3.5f, 0.5f);
        }
		if (age == 4) {
            SetPlayerCharacter(6f, 3.5f, 0.25f);
		}
		if (PlayerActions.gameOverCond) {
			SetPlayerCharacter(0f, 0f, 0f);
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
		if (collision.gameObject.tag == "Event Trap" && !superPlayer) {
			gameObj = collision.gameObject;
			setPombosConditions(true, true, 0);
		}
		if (collision.gameObject.tag == "Score") {
			ScoreActions.contador += Random.Range(5,10);
			Destroy(collision.gameObject);
		}
		
		if (collision.gameObject.tag == "Fases da Vida") {
			if (contadorFasesDavida == 0 && verificaFasesDaVida()) {
				Sound[0].SetActive(false);
				Sound[1].SetActive(true);
				age = 2;
				esposa = true;
				Debug.Log("esposa");
			} else if (contadorFasesDavida == 1 && verificaFasesDaVida()) {
				Sound[0].SetActive(false);
				Sound[1].SetActive(false);
				Sound[2].SetActive(true);
				age = 3;
				diploma = true;
				Debug.Log("diploma");
			} else if (contadorFasesDavida == 2 && verificaFasesDaVida()) {
				Sound[0].SetActive(false);
				Sound[1].SetActive(false);
				Sound[2].SetActive(false);
				Sound[3].SetActive(true);
				age = 4;
				guitarra = true;
				Debug.Log("guitarra");
			} else if (contadorFasesDavida == 3 && verificaFasesDaVida()) {
				mae = true;
				Debug.Log("mae");
			}
			contadorFasesDavida++;
			collision.gameObject.tag = "Untagged";
		}
	}

	void setPombosConditions(bool evWrp, bool boolPombos, int resetCounter) {
		eventWrapper 				= evWrp;
		PlayerActions.boolPombos 	= boolPombos;
		PlayerActions.contador	 	= resetCounter;
	}

	bool verificaFasesDaVida() {
		if (age == 1) {
			return !esposa && !diploma && !guitarra && !mae;
		}else if (age == 2) {
			return esposa && !diploma && !guitarra && !mae;
		}else if (age == 3) {
			return esposa && diploma && !guitarra && !mae;
		}else if (age == 4) {
			return esposa && diploma && guitarra && !mae;
		}
		return mae;
	}
}