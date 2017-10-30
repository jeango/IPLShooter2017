using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Behaviours/Pool Behaviour")]
public class PoolBehaviour : ObjectBehaviour {
	
	public ObjectBehaviour fallbackBehaviour;

	#region implemented abstract members of ObjectBehaviour

	public override void Execute (GameObject obj)
	{
		Poolable poolable = obj.GetComponent<Poolable> ();
		if (!poolable) {
			if (fallbackBehaviour)
				fallbackBehaviour.Execute (obj);
		}
		else
			poolable.TryPool ();
	}

	#endregion



}
