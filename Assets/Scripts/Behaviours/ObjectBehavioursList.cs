using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Behaviours/ObjBehavioursList")]
public class ObjectBehavioursList : ScriptableObject {

	public ObjectBehaviour[] behaviours;

	// Exécute toutes les behaviours dans l'ordre
	public void ExecuteAllBehaviours(GameObject obj) {
		foreach (var item in behaviours) {
			item.Execute (obj);
		}
	}
}
