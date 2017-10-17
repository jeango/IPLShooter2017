using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/PoolBehaviour")]
public class PoolBehaviour : ObjectBehaviour {

	[Tooltip("Behaviour to use if the object has no poolable component")]
	public ObjectBehaviour fallbackBehaviour;

	public override void Execute (GameObject param)
	{
		// on vérifie si le gameobject a un poolable
		Poolable poolable = param.GetComponent<Poolable> ();
		// si pas, alors on exécute la fallbackBehaviour
		if (!poolable) {
			if (fallbackBehaviour) {
				fallbackBehaviour.Execute (param);
			}
		} else
			// sinon on pool
			poolable.TryPool ();
	}

}

