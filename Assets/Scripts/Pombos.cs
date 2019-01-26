using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pombos : MonoBehaviour {

	private Collider col;
	// Use this for initialization
	void Start () {
		col = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () {
		PlayerActions.ContarPombos();
		Debug.Log(PlayerActions.contador);
		if (PlayerActions.contador == 6) {
			Destroy(this, 1f);
			//col.Destroy;
		}
	}
}
