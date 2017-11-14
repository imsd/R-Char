using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCube : MonoBehaviour {
	//renderer for this cube
	public Renderer rend;

	// Use this for initialization
	void Start () {
		//at start, get the Renderer component of this object
		//
		rend = GetComponent<Renderer> ();
	}
	// chages color when mouse is over object
	void OnMouseEnter(){
		rend.material.color = Color.red;
	}
	// changes color on mouse exit
	void OnMouseExit () {
		rend.material.color = Color.white;
	}
	// Update is called once per frame
	void OnMouseOver () {
		//Debug.Log ("hi");
		//transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);
	}
}
