using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeScript : MonoBehaviour {
	// Use this for initialization
	Vector3 originalPosition;
	Quaternion originalRotation;
	// Use this for initialization
	void Start () {
		originalPosition = gameObject.transform.position;
		originalRotation = gameObject.transform.rotation;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseOver() {
		if(Input.GetMouseButtonDown(1))
		{
			gameObject.transform.position = originalPosition;
			gameObject.transform.rotation = originalRotation;
		}
	}
}
