using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBehavior : MonoBehaviour {

	public float speed;


	// Use this for initialization
	void Start () {
		speed = Random.Range (0.5f, 3);		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (-speed * Time.deltaTime, 0, 0);	

		if (transform.position.x <= -15) {
			Destroy (this);
		}
	}
}
