using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsposaSpawner : MonoBehaviour {

	public GameObject [] objectEsposa;
	public float spawnTime;
	public Vector3 spawnPoint;
	public float spawnTimer = 0;
	// Use this for initialization
	void Start () {
		spawnTime = 36f;
	}
	// Update is called once per frame
	void FixedUpdate () {
		spawnTimer += 1 * Time.deltaTime;

		if (spawnTimer >= spawnTime && spawnTime != 0) {
            spawnTime = 0;
			Spawn ();
		}  
	}

	void Spawn ()	{
		spawnPoint.x = 15;
		spawnPoint.y = -1;
		Instantiate(objectEsposa[Random.Range(0, objectEsposa.Length - 1)], spawnPoint, Quaternion.identity);
     }
}
