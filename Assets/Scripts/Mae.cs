using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mae : MonoBehaviour {
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	private void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Player") {
            Time.timeScale = 1;
            Invoke("chamaCreditos", 8);
        }
	}

    void chamaCreditos() {
        SceneManager.LoadScene(3);
    }
}
