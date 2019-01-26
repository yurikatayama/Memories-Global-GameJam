using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IMGUOVER : MonoBehaviour {

	private float tx, ty;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		tx = Screen.width;
		ty = Screen.height;

		if (Input.GetKey(KeyCode.Space)) {
			SceneManager.LoadScene(1);
		}
	}

	void OnGUI() {

		if (GUI.Button(new Rect(tx/5, 7*ty/9, tx/5, ty/6), "MENU")){
			SceneManager.LoadScene(0);
		}

		if (GUI.Button(new Rect(3*tx/5, 7*ty/9, tx/5, ty/6), "Try Again")){
			SceneManager.LoadScene(1);
		}

	}
}
