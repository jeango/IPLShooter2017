using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {

	public Poolable projectilePrefab;

	public float fireInterval = 0.1f;

	private bool shooting = false;

	public void SetShooting (bool mode){
		shooting = mode;
		StopAllCoroutines ();
		if (mode) {
			StartCoroutine (FireCoroutine());
		}
	}

	void Fire() {
		//Instantiate (projectilePrefab, transform.position, transform.rotation);
		GameObject obj = projectilePrefab.GetInstance();
		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;

	}

	public IEnumerator FireCoroutine() {
		while (true) {
			if (shooting)
				Fire ();
			yield return new WaitForSeconds (fireInterval);
		}
	}
}
