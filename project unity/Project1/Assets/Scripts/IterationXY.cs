using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterationXY : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {

		//first loop thru x
		for (int x = 0; x < 10; x+=3) {
			// then for z

			for (int z = 0; z < 10; z++) {

				for (int y = 0; y < 10; y++) {
			
					Vector3 v = new Vector3 (x, 10, z);

					Instantiate (go, v, Quaternion.identity);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
