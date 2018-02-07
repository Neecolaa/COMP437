using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public float speed;
	private Rigidbody rigidb;


	// Use this for initialization
	void Start (){
		rigidb = GetComponent<Rigidbody>();
	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}

	//For Physics code
	void FixedUpdate (){
		float hMove = Input.GetAxis ("Horizontal");
		float vMove = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (hMove, 0.0f, vMove);

		rigidb.AddForce (movement * speed);
	}

	//For picking up cubes
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("FastBlock")) {
			other.gameObject.SetActive (false);
			speed *= 1.5f;
		} else if (other.gameObject.CompareTag ("SlowBlock")) {
			other.gameObject.SetActive (false);
			speed /= 1.5f;
		}
//		if (other.gameObject.CompareTag ("Consumable")){
//			
//			other.gameObject.SetActive (false);
//			if (other.gameObject.GetComponent (ConsumableCube.CubeType).Equals (Slow)) {
//				speed /= 1.5;
//			} else if (other.gameObject.GetComponent (ConsumableCube).Equals (Fast)) {
//				speed *= 1.5;
//			}
//		}
	}
}
