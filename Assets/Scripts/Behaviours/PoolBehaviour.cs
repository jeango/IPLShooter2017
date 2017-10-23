using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Behaviours/Pool Behaviour")]
public class PoolBehaviour : ObjectBehaviour {

	public ObjectBehaviour fallbackBehaviour;

	public override void Execute (GameObject obj)
	{
		Poolable poolable = obj.GetComponent<Poolable> ();
		if (poolable) {
			poolable.TryPool ();
		} else {
			if (fallbackBehaviour)
				fallbackBehaviour.Execute (obj);
		}
	}

}
