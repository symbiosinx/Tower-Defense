using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit_OLD : MonoBehaviour {

	public float distance = 30f; // distance from origin
	public float xSpeed = 120f, ySpeed = 120f; // rotation speed
	public float yMin = 15f, yMax = 80f; // rotation limit
	float x, y; // current rotation

	void LateUpdate() {
		if (Input.GetMouseButton(1)) { // right mouse button is pressed
			// Cursor.visible = false; // hide cursor
			float mouseX = Input.GetAxis("Mouse X"); // offset x rotation
			float mouseY = Input.GetAxis("Mouse Y"); // offset y rotation
			x += mouseX * xSpeed * Time.deltaTime;
			y -= mouseY * ySpeed * Time.deltaTime;
			y = Mathf.Clamp(y, yMin, yMax); // clamp y
		} else {
			Cursor.visible = true; // show cursor
		}
		transform.rotation = Quaternion.Euler(y, x, 0f);
		transform.position = -transform.forward * distance;
	}
}
