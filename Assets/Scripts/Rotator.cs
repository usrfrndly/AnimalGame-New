﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	// Rotate the transform
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	
	}
}
