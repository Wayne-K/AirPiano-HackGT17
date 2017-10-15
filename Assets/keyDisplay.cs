using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyDisplay : MonoBehaviour {
	TextMesh text;

	// Use this for initialization
	void Start () {
		text = GameObject.FindWithTag ("keyname").GetComponent<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.tag == "hand"){
			text.text = "Note: "+gameObject.name;
			Debug.Log ("note work");
		} 

	} // OnTriggerEventothe

}
