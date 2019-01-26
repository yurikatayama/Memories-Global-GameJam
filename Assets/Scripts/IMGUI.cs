using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IMGUI : MonoBehaviour {

	private float tx, ty;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		tx = Screen.width;
		ty = Screen.height;
	}

	void OnGUI() {

		if (GUI.Button(new Rect(tx/4, 5*ty/7, tx/2, ty/6), "Start Game")) {
			SceneManager.LoadScene(1);
		}

	}
}
