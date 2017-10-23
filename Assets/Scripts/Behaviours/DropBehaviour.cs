using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Behaviours/Drop Behaviour")]
public class DropBehaviour : ObjectBehaviour {

	public DropTable dropTable;

	public override void Execute (GameObject obj)
	{
		GameObject drop = dropTable.Drop ();
		if (drop) {
			Poolable poolable = drop.GetComponent<Poolable> ();
			if (poolable) {
				drop = poolable.GetInstance ();
			} else
				drop = Instantiate (drop);
			drop.transform.position = obj.transform.position;
		}
	}
}
