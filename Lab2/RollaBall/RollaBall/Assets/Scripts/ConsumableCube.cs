using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableCube : MonoBehaviour {



	public CubeType type;
//	// Use this for initialization
//	void Start () {
//		
//	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}

public enum CubeType {Normal, Slow, Fast};