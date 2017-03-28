using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorusRotation : MonoBehaviour {
	float RotationNumber;
	// Use this for initialization
	void Start () {
		RotationNumber = Random.Range (0.0f, 4.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (RotationNumber > 0.0f && RotationNumber < 1.0f) {
			transform.Rotate (180f * Time.deltaTime, 0f, 0f);
		}
		if (RotationNumber > 1.0f && RotationNumber < 2.0f) {
			transform.Rotate (-180f * Time.deltaTime, 0f, 0f);
		}
		if (RotationNumber > 2.0f && RotationNumber < 3.0f) {
			transform.Rotate (0f,0f, 180f * Time.deltaTime);
		}
		if (RotationNumber > 3.0f && RotationNumber < 4.0f) {
			transform.Rotate (0f,0f, -180f * Time.deltaTime);
		}
	}
}
