using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour {

	float timer;

	// Use this for initialization
	void Start () {
		timer = 0;
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {

		timer += 1 * Time.deltaTime;

		if (timer >= 28.9f) {
			SceneManager.LoadScene(0);
		}
		
	}
}
