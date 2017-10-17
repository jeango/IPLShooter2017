using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCleaner : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col) {

		GameObject daObject;

		// on récupère le rigidbody auquel le collider est lié, s'il y en a un
		Rigidbody2D rb = col.attachedRigidbody;

		if (rb) {
			daObject = rb.gameObject;
		} 
		// s'il y a pas de rigidbody, on va détruire l'objet auquel appartient le collider
		else
			daObject = col.gameObject;
		// S'il a un poolable, on le pool
		Poolable poolable = daObject.GetComponent<Poolable> ();
		if (poolable) {
			poolable.TryPool ();
		} else
			// sinon on le détruit
			Destroy (daObject);
	}

}
