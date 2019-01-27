using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arvore : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	private void OnTriggerStay2D(Collider2D collider) {
		 if (condicoesOpacity(collider)) GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .3f);
	}

	private void OnTriggerExit2D(Collider2D collider) {
		if (condicoesOpacity(collider)) GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
	}

	private bool condicoesOpacity(Collider2D collider) {
		return collider.gameObject.tag == "Player"
				|| collider.gameObject.tag == "Fases da Vida"
				|| collider.gameObject.tag == "Score"
				|| collider.gameObject.tag == "Event Trap";
	}
}
