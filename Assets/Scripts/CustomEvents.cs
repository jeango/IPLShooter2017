using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ne pas oublier d'inclure ceci: 
using UnityEngine.Events;

// Ce namespace nous permet d'utiliser "using My.Events" lorsqu'on a besoin d'events custom
namespace My.Events{
	// Ne pas oublier de rendre l'event serialisable afin 
	// qu'il puisse s'afficher dans l'inspecteur
	[System.Serializable]
	public class ObjectEvent : UnityEvent<GameObject>{};
}

