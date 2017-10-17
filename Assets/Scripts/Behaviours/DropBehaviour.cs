using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Behaviours/DropBehaviour")]
public class DropBehaviour : ObjectBehaviour {

	public DropTable dropTable;

	public override void Execute (GameObject obj)
	{
		// on drop avec la droptable
		GameObject drop = dropTable.Drop();
		// on vérifie s'il y a quelque chose à droper
		if (drop) {
			// on instancie ou on pool, selon que l'objet est poolable ou pas
			Poolable poolable = drop.GetComponent<Poolable>();
			if (poolable) {
				drop = poolable.GetInstance ();
			} else
				drop = Instantiate (drop);
			// on positione le drop à la position du gameobject reçu en référence
			drop.transform.position = obj.transform.position;
		}
	}
}
