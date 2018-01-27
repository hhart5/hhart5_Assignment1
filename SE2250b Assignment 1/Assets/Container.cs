using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour {
	int clickCount = 0;
	// Use this for initialization
	void Start () 
	{
		gameObject.transform.Rotate(Random.Range(0.0f, 10.0f), 0, Random.Range(0.0f,10.0f));
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0))
		{
			if (clickCount <= 2) {
				gameObject.transform.Rotate (Random.Range (-10.0f, 10.0f), 0, Random.Range (-10.0f, 10.0f));
				clickCount++;
			} else {
				gameObject.transform.Rotate (Random.Range (-25.0f, 25.0f), 0, Random.Range (0.0f, 25.0f));

			}
		}
	}
}
