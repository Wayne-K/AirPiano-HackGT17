using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class Testscript : MonoBehaviour {
	public AudioClip impact;
	public AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (this.tag == "Piano"){
			audio.Play();
			audio.PlayOneShot (impact);
			Debug.Log ("yo");
		} 
		else {
			audio.Stop();
		}
	}

}
