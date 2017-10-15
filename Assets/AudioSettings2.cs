using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings2 : MonoBehaviour {

	void start()
	{

	}
	void Update()
	{

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "hand")
			AudioListener.volume = 1;
	}
}
