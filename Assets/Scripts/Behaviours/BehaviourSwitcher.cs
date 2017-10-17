using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourSwitcher : MonoBehaviour {

	public AbstractBehaviour behaviour1;
	public AbstractBehaviour behaviour2;
	private AbstractBehaviour currentBehaviour;

	void OnEnable () {

		ErrorMessageBehaviour runtimeBehaviour = ScriptableObject.CreateInstance<ErrorMessageBehaviour> ();
		runtimeBehaviour.message = "Spash!";

		currentBehaviour = runtimeBehaviour;
	}

	void Update() {
		float axis = Input.GetAxisRaw ("Vertical");
		if (axis > 0) {
			currentBehaviour = behaviour2;
		}
		if (axis < 0) {
			currentBehaviour = behaviour1;
		}
		if (Input.GetButtonDown ("Fire1")) {
			currentBehaviour.Execute ();
		}
	}
}
