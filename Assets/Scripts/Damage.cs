using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	public int damage;

	void OnTriggerEnter2D(Collider2D col) {
		Rigidbody2D rb = col.attachedRigidbody;
		if (rb) {
			Health health = rb.GetComponentInChildren<Health> ();
			if (health) {
				health.TakeDamage (damage);
			}
		}
	}

}
