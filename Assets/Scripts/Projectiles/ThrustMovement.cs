using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Rigidbody2D))]
public class ThrustMovement : MonoBehaviour {

	public float thrust;
	public float maxSpeed;

	private Rigidbody2D rb;

	void Awake() {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = transform.right * maxSpeed;
	}

	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce (transform.right * thrust, ForceMode2D.Force);
		if (rb.velocity.magnitude > maxSpeed) {
			rb.velocity = rb.velocity.normalized * maxSpeed;
		}
	}
	void Update() {
		Debug.DrawRay (transform.position, transform.right, Color.red);
			
	}
}
