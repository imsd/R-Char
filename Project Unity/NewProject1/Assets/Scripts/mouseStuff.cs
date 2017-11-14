using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseStuff : MonoBehaviour {
	public float forcePower = 1000f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// this function is called when mouse is over the object
	void OnMouseDown() {
		Vector3 forceDirection = Vector3.forward * forcePower; 
		GetComponent<Rigidbody> ().AddForce (forceDirection);
		//transform.Rotate (new Vector3 (0, 90, 0) * Time.deltaTime);
	}
}
