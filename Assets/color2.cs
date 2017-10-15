using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color2 : MonoBehaviour {
	public float colourChangeDelay = 0.5f;
	float currentDelay = 0f;
	bool colourChangeCollision = false;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		checkColourChange();
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("Contact was made!");
		colourChangeCollision = true;
		currentDelay = Time.time + colourChangeDelay;
	}

	void checkColourChange()
	{        
		if(colourChangeCollision)
		{
			GetComponent<Renderer>().material.color = Color.yellow;
			if(Time.time > currentDelay)
			{
				GetComponent<Renderer>().material.color = Color.white;
				colourChangeCollision = false;
			}
		}
	}

}
