using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICannonController : MonoBehaviour {

	public Canon canon;

	public float minShootingDelay;
	public float maxShootingDelay;

	void OnEnable() {
		StartCoroutine (StartShooting());
	}
	void OnDisable() {
		StopAllCoroutines ();
	}

	IEnumerator StartShooting() {
		canon.SetShooting (false);
		float delay = Random.Range (minShootingDelay, maxShootingDelay);
		yield return new WaitForSeconds (delay);
		canon.SetShooting (true);
	}


}
