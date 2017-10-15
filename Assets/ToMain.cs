using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMain : MonoBehaviour {

	public float speed;



	void Update ()
	{
		speed = Random.Range (10f, 30f);
		transform.Rotate(Vector3.up, speed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "hand") {
			Application.LoadLevel ("Main");
		}
	}
}
