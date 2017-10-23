using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using My.Events;

public class Owner : MonoBehaviour {

	public GameObject owner;

	public ObjectEvent OnSetOwner;

	public void SetOwner(GameObject owner) {
		this.owner = owner;
		// ceci va permettre à des objets fils de mettre à jour leur propre owner
		OnSetOwner.Invoke (owner);
	}

	// Cette méthode va nous servir lorsqu'on instancie un objet par exemple
	public void Own(GameObject target) {
		Owner owner = target.GetComponent<Owner> ();
		if (owner) {
			owner.SetOwner (this.owner);
		}
	}

}

