using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSpawner : MonoBehaviour {

	public GameObject [] objectScore;
	public float spawnTime;
	public Vector3 spawnPoint;
	public float spawnTimer = 0;
	// Use this for initialization
	void Start () {
		spawnTime = 6f;
	}
	
	// Update is called once per frame

	void FixedUpdate () {
		spawnTimer += 1 * Time.deltaTime;

		if (spawnTimer > 1) {
			spawnTimer -= 0.30f * Time.deltaTime;
		}

		if (spawnTimer > spawnTime) {
			Spawn ();
			spawnTimer = 0;
		}  
	}

	void Spawn ()	{
		spawnPoint.x = Random.Range(14, 16);
		spawnPoint.y = Random.Range(-1, 4);
		Instantiate(objectScore[Random.Range(0, objectScore.Length - 1)], spawnPoint, Quaternion.identity);
     }
}
