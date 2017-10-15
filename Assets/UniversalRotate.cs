using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalRotate : MonoBehaviour {
	private float speed; 
	// Use this for initialization
	void Start () {
		speed = Random.Range (10f, 30f);
	}
	
	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime);

	}
}
