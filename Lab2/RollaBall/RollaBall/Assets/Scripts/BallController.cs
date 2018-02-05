using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public float speed;
	private Rigidbody rigidb;


	// Use this for initialization
	void Start ()
	{
		rigidb = GetComponent<Rigidbody>();
	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}

	//For Physics code
	void FixedUpdate ()
	{
		float hMove = Input.GetAxis ("Horizontal");
		float vMove = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (hMove, 0.0f, vMove);

		rigidb.AddForce (movement * speed);
	}
}
