using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using My.Events;

public class Health : MonoBehaviour {

	public int initHealth;
	public int currentHealth;
	public ObjectBehavioursList dieBehaviours;

	// Ce champ va contenir une référence à l'objet
	// qui est la source du dernier dégât reçu
	public GameObject damageSource;

	// avec using My.Events
	public ObjectEvent OnDie;

	void OnEnable() {
		currentHealth = initHealth;
		// important de remettre à null lorsqu'on active
		damageSource = null;
	}
		
	public void TakeDamage(int damage, GameObject source=null) {
		currentHealth -= damage;
		// on met à jour la source des dégâts si elle est connue
		if (source)
			damageSource = source;

		if (currentHealth <= 0) {
			Die ();
		}
	}

	public void Die() {
		// bien veiller à invoquer OnDie avant d'exécuter les behaviours
		OnDie.Invoke (damageSource);
		dieBehaviours.ExecuteBehaviours (gameObject);
	}
}
