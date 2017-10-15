using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public float speed = 25f;
	public int num = 0;


	void Update ()
	{
		// transform.Rotate(Vector3.up, speed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "hand") {
			Debug.Log (num);
			num++;
			Application.LoadLevel ("Teleport!");
		}
	}

}