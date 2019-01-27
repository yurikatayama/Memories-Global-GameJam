using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Text score;
	void Start () {
		score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + ScoreActions.contador;
	}

	private void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Event Trap") {
			Destroy(this);
		}
		if (collider.gameObject.tag == "Score") {
			Destroy(collider.gameObject);
		}
		if (collider.gameObject.tag == "Fases da Vida") {
			Destroy(this);
		}
	}
}
