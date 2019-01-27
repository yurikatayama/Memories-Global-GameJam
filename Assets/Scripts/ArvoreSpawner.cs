using UnityEngine;

public class ArvoreSpawner : MonoBehaviour {

	public GameObject [] objectsArvore;
	public float spawnTime;
	public Vector3 spawnPoint;
	public float spawnTimer = 0;

	// Use this for initialization
	void Start () {
		spawnTime = Random.Range (1,11);

	}
	
	void FixedUpdate () {
		if (PlayerActions.gameOverCond) {
			spawnTime = 0;
			spawnTimer = 0;
		} else {
			spawnTimer += 1 * Time.deltaTime;

			if (spawnTimer > 1) spawnTimer -= 0.15f * Time.deltaTime;

			if (spawnTimer > spawnTime) {
				Spawn ();
				spawnTimer = 0;
			} 
		}

		
	}

	void Spawn ()	{
         spawnPoint.x = 15;
         spawnPoint.y = Random.Range(-2, 0);
         Instantiate(objectsArvore[Random.Range(0, objectsArvore.Length - 1)], spawnPoint, Quaternion.identity);
    }
}
