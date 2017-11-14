using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// if we say public before a variable type
	// it will show up in the inspector

	// Vector3 is a variable type that stores
	// X, Y, and Z information

	// in this case, we are naming the variable
	// 'myRotation' so we know how to talk about it
	public Vector3 myRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (myRotation * Time.deltaTime);
	}
}
