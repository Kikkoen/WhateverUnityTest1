﻿using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {

	public int rotationOffset = 90; 
	
	// Update is called once per frame
	void Update () {

		Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position; 		// Subtraction position of the player from the mouse position
		difference.Normalize (); 			// Normalizing vector meaning that the sum of the vector will be equal to 1


		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg; // Find angle in degrees 
		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);
	}
}
