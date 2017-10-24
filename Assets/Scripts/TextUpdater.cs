using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TextUpdater : MonoBehaviour {

	public Text text;

	public void UpdateText(string newText) {
		text.text = newText;
	}

	// on fournit également une version qui accepte un int
	// sinon on ne pourra pas souscrire à l'event
	public void UpdateText(int newText) {		
		// Autre option: newText.ToString()
		UpdateText(newText + "");
	}

}
