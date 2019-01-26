using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diploma : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Score") {
			Destroy(collider.gameObject);
		}
		if (collider.gameObject.tag == "Event Trap") {
			Destroy(collider.gameObject);
		}
	}
}
