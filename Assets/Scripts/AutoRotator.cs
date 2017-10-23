﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotator : MonoBehaviour {

	public float rotationSpeed;

	void Update() {
		transform.Rotate (transform.up, rotationSpeed * Time.deltaTime);
	}

}