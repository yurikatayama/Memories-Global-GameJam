using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBehavior : MonoBehaviour {

	private float speed;


	// Use this for initialization
	void Start () {
		speed = 0.5f;		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (-speed * Time.deltaTime, 0, 0);
		if (transform.position.x <= -15) {
			Destroy(this);
		}
	}
}
