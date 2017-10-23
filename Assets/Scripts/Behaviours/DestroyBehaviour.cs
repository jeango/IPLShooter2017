using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Behaviours/Destroy Behaviour")]
public class DestroyBehaviour : ObjectBehaviour {
	
	public override void Execute (GameObject obj)
	{
		Destroy (obj);
	}
	
}
