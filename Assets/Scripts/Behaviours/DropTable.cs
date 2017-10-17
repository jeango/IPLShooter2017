using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Drop Table")]
public class DropTable : ScriptableObject {

	// la liste de ce qu'on peut dropper
	public DropTableElement[] drops;
	// le poids total de tous les éléments dans la liste
	int totalWeight;

	void OnEnable() {
		totalWeight = 0;
		if (drops.Length > 0) {
			foreach (var item in drops) {
				totalWeight += item.weight;
			}
		}
	}

	public GameObject Drop() {
		// on détermine une valeur aléatoire entre 1 et totalWeight
		int roll = Random.Range(0, totalWeight)+1;
		// le curseur va sélectionner un élément dans la table
		int cursor = 0;
		// on va boucler sur toute la table jusqu'à atteindre le roll
		foreach (var item in drops) {
			cursor += item.weight;
			if (cursor >= roll)
				return item.dropPrefab;
		}
		return null;
	}
}

// Cette classe sert à définir un élément de la droptable
[System.Serializable]
public class DropTableElement {
	// le poids sert à déterminer la probabilité de l'objet à dropper
	public int weight;
	public GameObject dropPrefab;
}
