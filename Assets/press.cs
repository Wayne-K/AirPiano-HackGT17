using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class press : MonoBehaviour {
	public Vector3 startingCoord;
	public float speed;
	public float max;

	// Use this for initialization
	void Start () {
//		startingCoord = gameObject.transform.position;
//		speed = 10;
//		max = .5f;
	}
	
	// Update is called once per frame
	void Update () {
//		if (gameObject.transform.position.y == max) {
//			gameObject.transform.position += new Vector3 (0f, -.1f, 0);
//		} // if
	}

	void OnTriggerEnter(Collider c) {
		//gameObject.transform.position += new Vector3 (0, 5, 0);
//		if (c.tag == "hand") {
//			gameObject.transform.position += new Vector3 (0f, .1f, 0f);
//		} // if
	} // OnCollisionEnter
}
