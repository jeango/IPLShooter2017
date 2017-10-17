using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour {

	// Ceci permet de déterminer quel "tag" les cibles doivent avoir
	public string targetTag = "Player";

	// la vitesse de rotation en degrés par seconde
	public float rotationSpeed = 10f;

	// La cible actuelle du missile
	private GameObject target;

	// On initialise la cible lorsqu'on active l'objet (si nécessaires)
	void OnEnable () {
		if (!target) {
			target = GameObject.FindGameObjectWithTag ("Player");
		}
	}
	
	void Update () {
		if (target)
			HomingRotation ();
	}

	void HomingRotation() {
		// On détermine la direction relative du missile vers la cible
		Vector3 directionToTarget = target.transform.position - transform.position;
		// On détermine l'angle entre la direction cible et le vecteur "right" du transform
		float angleToTarget = Vector3.Angle(transform.right, directionToTarget);
		// On détermine le vecteur perpendiculaire aux deux vecteurs
		// Ce vecteur servira d'axe de rotation
		Vector3 rotationAxis = Vector3.Cross(transform.right, directionToTarget);
		// On limite l'angle de rotation de sorte à ce qu'il ne dépasse pas la vitesse définie
		angleToTarget = Mathf.Clamp(angleToTarget, angleToTarget, rotationSpeed*Time.deltaTime);
		// On applique la rotation
		transform.Rotate(rotationAxis, angleToTarget);
	}
}
