using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour {

	void start()
	{
		
	}
	void Update()
	{
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "hand")
			AudioListener.volume = 0;
	}
}
