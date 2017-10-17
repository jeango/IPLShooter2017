using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomEvents;

public class Health : MonoBehaviour {

	public int initHealth;
	public int currentHealth;

	public ObjectBehavioursList dieBehaviours;

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
		dieBehaviours.ExecuteAllBehaviours (gameObject);
	}
}
