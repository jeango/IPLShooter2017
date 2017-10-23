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
				
				// on récupère le owner
				Owner owner = gameObject.GetComponent<Owner> ();
				// on initialise la source (null si on a pas de Owner)
				GameObject source = owner ? owner.owner : null;
				// on le passe dans takedamage
				health.TakeDamage (damage, source);

			}
		}
	}

}
