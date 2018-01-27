using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildContainerScript : MonoBehaviour {

	private Container container;
	// Use this for initialization
	void Start () {
		container = gameObject.GetComponentInParent<Container> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver () {
		container.OnMouseOver();
	}
}
