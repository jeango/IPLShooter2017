using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poolable : MonoBehaviour {

	public void OnPool() {
		gameObject.SetActive (false);
	}

	public void OnUnpool() {
		gameObject.SetActive (true);
	}
}
