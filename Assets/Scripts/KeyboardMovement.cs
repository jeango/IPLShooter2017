using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyboardMovement : MonoBehaviour {

	[SerializeField]
	int speed = 1;

	public Rect bounds;

	void Awake() {
		bounds = ScreenToRect (1f);
	}

	// Use this for initialization
	void Start () {
		
	}
		

	// Update is called once per frame
	void Update () {
		KinematicMovement ();
	}



	void KinematicMovement() {
		
		Vector3 velocity = GetAxisVector ();
		velocity *= speed * Time.deltaTime;
		transform.position += velocity;

		ClampPosition ();

	}

	Vector3 GetAxisVector() {
		float hDirection = Input.GetAxisRaw ("Horizontal");
		float vDirection = Input.GetAxisRaw ("Vertical");
		return new Vector3 (hDirection, vDirection, 0);
	}

	void ClampPosition() {
		Vector3 newPos = transform.position;
		newPos.x = Mathf.Clamp (transform.position.x, bounds.xMin, bounds.xMax);
		newPos.y = Mathf.Clamp (transform.position.y, bounds.yMin, bounds.yMax);

		transform.position = newPos;
	}

	void OnDrawGizmos() {
		GizmoUtils.DrawRectangle (bounds, Color.green);
	}

	Rect ScreenToRect(float margin) {
		Camera cam = Camera.main;
		Vector3 bottomLeft = cam.ScreenToWorldPoint (Vector3.zero);
		Vector3 topRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));

		Rect rect = Rect.MinMaxRect (bottomLeft.x, bottomLeft.y, topRight.x, topRight.y);

		rect.x += margin;
		rect.y += margin;
		rect.width -= margin * 2;
		rect.height -= margin * 2;

		return rect;
			
	}
}
