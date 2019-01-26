using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaeSpawner : MonoBehaviour {

	public GameObject [] objectMae;
	public float spawnTime;
	public Vector3 spawnPoint;
	public float spawnTimer = 0;
	// Use this for initialization
	void Start () {
		spawnTime = 100f * 11.5f;
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
		Instantiate(objectMae[Random.Range(0, objectMae.Length - 1)], spawnPoint, Quaternion.identity);
     }
}
