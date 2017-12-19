using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circularMovement : MonoBehaviour {

	// for circular movement we dont really need to 
	// "keep track" of x and z, we just need to keep track
	// of "what point of the circle" are we at? like, in degrees,
	// or in this case in Radians (0 -> 2 pi)
	private float theta = 0f; 
	private float pitch = 0f;
    private float ypos = 0f;

	// and how far from center should it be?
	public float radius = 5f;
	
	void Update () {
		print(Mathf.Tan(0.5F));
		// keyboard input changes theta
		theta += Input.GetAxis ("Horizontal") * .1f;	// multiply by 10%, otherwise it moves too fast
		pitch += Input.GetAxis ("Vertical") * .1f;	// multiply by 10%, otherwise it moves too fast

		// then derive X and Z location from that, so it move
		// in a circle
		float xPos = Mathf.Cos (theta) * radius;
		float zPos = Mathf.Sin (theta) * radius;// if this were 2d, we would use y instead of z
        Debug.Log(pitch);
        Debug.Log(ypos);

		// do it
		transform.position = new Vector3 (xPos, 1, zPos);
		transform.position = new Vector3 (xPos,pitch,zPos);
        

        if ( ypos == 5){
                pitch = pitch * -1;
        }
        if (ypos == -2){
                pitch = pitch * -1;
        }


    }
}
