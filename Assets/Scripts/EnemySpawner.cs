using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public float minInterval;
	public float maxInterval;
	public float minY = -7f;
	public float maxY = 7f;

	public float minSpawnDistance = 1f;

	public Poolable enemyPrefab;

	public LayerMask layerMask;


	// Use this for initialization
	void OnEnable () {
		StartCoroutine (SpawnCoroutine ());		
	}

	// Use this for initialization
	void OnDisable () {
		StopAllCoroutines ();		
	}


	void SpawnEnemy() {
		
		Vector3 spawnPosition;
		if (TryFindPosition (10, out spawnPosition)) {
			//Instantiate (enemyPrefab, spawnPosition, transform.rotation);
			GameObject obj = enemyPrefab.GetInstance();
			obj.transform.position = spawnPosition;
			obj.transform.rotation = transform.rotation;
		}
	}

	bool TryFindPosition(int maxAttempts, out Vector3 position) {
		position = GetRandomPosition ();
		for (int i = 0; i < maxAttempts; i++) {
			if (!Physics2D.OverlapCircle (position, minSpawnDistance, layerMask))
				return true;
		}
		position = Vector3.zero;
		return false;
	}


	Vector3 GetRandomPosition() {
		Vector3 tmpPos = transform.position;
		tmpPos.y = Random.Range (minY, maxY);
		return tmpPos;
	}

	IEnumerator SpawnCoroutine() {
		while (true) {
			SpawnEnemy ();
			yield return new WaitForSeconds (Random.Range (minInterval, maxInterval));
		}
	}
}
