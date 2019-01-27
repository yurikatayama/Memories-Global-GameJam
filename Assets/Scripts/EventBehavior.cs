using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBehavior : MonoBehaviour {

	public float speed;


	// Use this for initialization
	void Start () {
		speed = 0.5f;		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (-speed * Time.deltaTime, 0, 0);	
		
		if (PlayerActions.gameOverCond) speed = 0;

		if (transform.position.x <= -15) Destroy (this);
	}
}
