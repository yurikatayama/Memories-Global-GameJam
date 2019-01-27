using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nuvem : MonoBehaviour {

	Text score;
	void Start () {
		GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .6f);
	}
	
	// Update is called once per frame
	void Update () {}

}
