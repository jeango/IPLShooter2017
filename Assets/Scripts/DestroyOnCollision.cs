using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {

	public LayerMask layerMask;

	void OnTriggerEnter2D(Collider2D col) {

		if (layerMask == (layerMask | (1 << col.gameObject.layer))) {
			if (!ObjectPoolsManager.Instance.PoolObject(gameObject))
				Destroy (gameObject);
		}
	}

}
