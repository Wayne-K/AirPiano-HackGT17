using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	public float speed = 10f;



	void Update ()
	{
		transform.Rotate (0,0,50*Time.deltaTime);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "hand") {
			Application.LoadLevel ("Teleport!");
		}
	}

}