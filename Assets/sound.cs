using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {
	public AudioClip key;
	public AudioSource audio;
	public ParticleSystem psystem;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		//psystem = GetComponent<ParticleSystem> ();

	}

	// Update is called once per frame
	void Update () {
		//psystem.Stop ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "hand"){
			audio.Play();
			audio.PlayOneShot (key);
			//psystem.Play ();
			Debug.Log ("yo");
		} 

	} // OnTriggerEventothe
}
