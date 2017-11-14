using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCube : MonoBehaviour {

	// the renderer for this cube
	public Renderer rend;

	void Start() {
		// at start, get the Renderer component of this object
		// and set it to rend
		rend = GetComponent<Renderer> ();
	}

	// on mouse enter happens when you START to hover an object w cursor
	void OnMouseEnter() {
		rend.material.color = Color.red;
	}

	// on mouse exit happens when your cursor leaves an object
	void OnMouseExit() {
		rend.material.color = Color.white;
	}

	// on mouse over happens while your cursor is on an object
	void OnMouseOver() {
		
		// add .01 to all axes scale
		transform.localScale += new Vector3 (.01f, .01f, .01f);

	}
}
