using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyOffSet : MonoBehaviour {

	private Renderer rendy;
	public float speed;
	private float offset;

	// Use this for initialization
	void Start () {
		
		rendy = GetComponent<Renderer>();
		speed = Random.Range (0.005f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerActions.gameOverCond) {
			speed = 0;
		}
		offset += Time.deltaTime * -speed;
		rendy.material.SetTextureOffset ("_MainTex", new Vector2 (-offset, 0));
		
	}
}
