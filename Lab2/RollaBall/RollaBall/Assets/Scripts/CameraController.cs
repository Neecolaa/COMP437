using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject focus;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - focus.transform.position;
	}
	
	// LateUpdate is called once per frame, but after everthing else(?)
	void LateUpdate () {
		transform.position = focus.transform.position + offset;
	}
}
