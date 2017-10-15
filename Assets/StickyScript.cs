using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyScript : MonoBehaviour {
	private bool _indexColliding = false;
	private bool _thumbColliding = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//override super method
	void OnCollisionEnter(Collision c) {
		if (c.collider.gameObject.tag == "hand") {
			var joint = gameObject.AddComponent<FixedJoint> ();
			joint.connectedBody = c.rigidbody;
		} // if

//		 keep track of the colliding objects
//		if (other.gameObject.tag == "index")
//			_indexColliding = true;
//		else if (other.gameObject.tag == "thumb")
//			_thumbColliding = true;
//
//		if (_indexColliding && _thumbColliding) {
//			// do something like attaching the object to the fingers
//			// or destroy the gameObject
//			c.gameObject.transform.parent =
//		}


	} // OnCollisionEnter
}
