using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int initHealth;
	public int currentHealth;

	public GameObject damageDealer;

	public ObjectBehavioursList dieBehaviours;
	public ObjectBehavioursList dieDamageDealerBehaviours;

	void OnEnable() {
		currentHealth = initHealth;
	}

	public void TakeDamage(int damage, GameObject source = null) {
		if (source)
			damageDealer = source;
		currentHealth -= damage;
		if (currentHealth <= 0) {
			Die ();
		}
	}

	public void Die() {
		if (dieBehaviours)
			dieBehaviours.Execute (gameObject);
		if (dieDamageDealerBehaviours)
			dieDamageDealerBehaviours.Execute (damageDealer);
	}
}
