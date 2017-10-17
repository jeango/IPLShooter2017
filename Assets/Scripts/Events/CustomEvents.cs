using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// pour utiliser ces events, il suffira d'ajouter "using CustomEvents"
namespace CustomEvents
{
	// Cet event sera utilisé pour des événements qui sont produit par un objet
	[System.Serializable]
	class ObjectEvent : UnityEvent<GameObject> {}

	// Cet event sera utilisé pour des événements qui résultent de l'intéraction entre deux objets
	[System.Serializable]
	class ObjectInteractionEvent : UnityEvent<GameObject, GameObject> {}

	// Cet event sera utilisé pour transmettre un message
	[System.Serializable]
	class MessageEvent : UnityEvent<string> {}

}

