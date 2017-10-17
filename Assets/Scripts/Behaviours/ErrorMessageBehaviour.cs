using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ceci permet d'ajouter un menu contextuel pour créer une 
// nouvelle version de ce ScriptableObject
[CreateAssetMenu (menuName = "MessageBehaviours/Error")]
public class ErrorMessageBehaviour : AbstractBehaviour {

	// On va définir le message à afficher dans l'inspecteur
	public string message;

	public override void Execute ()
	{
		Debug.LogError (message);
	}
}
