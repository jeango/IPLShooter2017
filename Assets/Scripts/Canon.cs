using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {

	public Poolable projectilePrefab;

	public float fireInterval = 0.1f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			StartCoroutine (FireCoroutine ());
		}
		if (Input.GetButtonUp("Fire1")) {
			StopAllCoroutines ();
		}
	}

	void Fire() {
		//Instantiate (projectilePrefab, transform.position, transform.rotation);
		Poolable obj = ObjectPoolsManager.Instance.GetObject(projectilePrefab);
		obj.transform.position = transform.position;
		obj.transform.rotation = transform.rotation;

	}

	IEnumerator FireCoroutine() {
		while (true) {
			Fire ();
			yield return new WaitForSeconds (fireInterval);
		}
	}

}
