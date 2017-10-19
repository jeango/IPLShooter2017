using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour {

	public GameObject target;
	public string targetTag;
	public int rotationSpeed;

	void OnEnable() {
		if (!target)
			target = GameObject.FindGameObjectWithTag (targetTag);
	}
		
	void Update() {
		if (target) {
			Vector3 direction = target.transform.position - transform.position;
			float angleToTarget = Vector3.Angle (transform.right, direction);
			float rotationAngle = rotationSpeed * Time.deltaTime;
			rotationAngle = Mathf.Clamp (rotationAngle, rotationAngle, angleToTarget);
			Vector3 rotationAxis = Vector3.Cross (transform.right, direction);
			transform.Rotate (rotationAxis, rotationAngle);
		}
	}

}
