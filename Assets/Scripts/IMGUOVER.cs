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

		GUI.Box(new Rect(tx/4, 5*ty/7, tx/2, ty/6), "Iu Lost\nO T Á R I O !\n da espaço aí");

	}
}
