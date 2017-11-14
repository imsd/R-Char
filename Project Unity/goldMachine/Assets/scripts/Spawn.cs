using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	 
	//adds GameObject to the inspector
	//allows you access in the script
	public GameObject go;
	// start spawing after x seconds

	public float StartAfter = 1f;
	// how often it spawns
	public float Freq = 2.0f;
	// Use this for initialization
	void Start () {
		//do something every x seconds
		//1; the opbect you want repeated
		// after how many seconds do you want to start doing it?
		//3;repeat every x seconds
		InvokeRepeating("SpawnThing" , StartAfter, Freq);

		//first, move the spawn point

	}
	
	// Update is called once per frame
	void SpawnThing () {
		// to create an object use the Instantiate function 
		// which needs 3 arguements
		//1;the object you will create
		//2;where to create the object
		//3;at what rotation or the default rotation of the object
		Instantiate (go, transform.position, Quaternion.identity);

		Debug.Log (transform.position);
		//transform.position = new Vector3 (Random.Range(-5f,5f), 3, Random.Range(-5f,5f));
	}
}
