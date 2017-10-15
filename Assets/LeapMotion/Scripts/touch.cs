using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*
	private bool IsHand(Collider other)
	{
		if (other.transform.parent && other.transform.parent.parent &&     other.transform.parent.parent.GetComponent<HandModel>())//what is the class for hand called
			return true;
		else
			return false;
	}
    

	void OnTriggerEnter(Collider other) 
	{
		if (IsHand(other))
		{
			Debug.Log("A hand collided!");
			GetComponent<AudioSource>().Play ();
		}  
	}
    */
}
