using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBehavior : MonoBehaviour {

	public float speed;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (-speed * Time.deltaTime, 0, 0);	
		
		if (PlayerActions.gameOverCond) {
			speed = 0;
		}

		if (transform.position.x <= -25) {
			Destroy (this);
		}
	}
}
