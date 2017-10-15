using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToBasketball : MonoBehaviour {

	public float speed = 25f;



	void Update ()
	{
		transform.Rotate(Vector3.up, speed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other)
	{
		//if (other.tag == "hand") {
		//	Application.LoadLevel ("Basketball");
		//}
	}
}
