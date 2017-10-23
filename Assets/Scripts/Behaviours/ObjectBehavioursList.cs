using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Behaviours/BehavioursList")]
public class ObjectBehavioursList : ScriptableObject {

	public ObjectBehaviour[] behaviours;

	public void ExecuteBehaviours(GameObject obj) {
		foreach (var item in behaviours) {
			item.Execute (obj);
		}
	}

}
