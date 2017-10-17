using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICanonController : MonoBehaviour {

	public Canon canon;

	public float minDelayBeforeShooting;
	public float maxDelayBeforeShooting;

	void OnEnable() {
		StartCoroutine (ShootingCoroutine ());
	}

	void OnDisable() {
		StopAllCoroutines ();
	}

	IEnumerator ShootingCoroutine() {
		canon.SetShooting (false);
		yield return new WaitForSeconds (Random.Range (minDelayBeforeShooting, maxDelayBeforeShooting));
		canon.SetShooting (true);
	}

}
