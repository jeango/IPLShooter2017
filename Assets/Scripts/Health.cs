using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int initHealth;
	public int currentHealth;

	void OnEnable() {
		currentHealth = initHealth;
	}

	public void TakeDamage(int damage) {
		currentHealth -= damage;
		if (currentHealth <= 0) {
			Die ();
		}
	}

	public void Die() {
		if (!ObjectPoolsManager.Instance.PoolObject(gameObject))
			Destroy (gameObject);
	}
}
