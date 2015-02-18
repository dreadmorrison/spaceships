using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class spaceshipMoveme : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// move forward if I press W
		// GetKeyDown = tapping, GetKey = holding

		if ( Input.GetKey ( KeyCode.W ) ) 
		{ // Time.deltaTime is the fraction of a second in between a frame
			// a value that gets bigger with low FPS, smaller with high FPS
			transform.position += new Vector3( 0f, 0f, 200f ) * Time.deltaTime;
		}

		// move backward if I press S
		if ( Input.GetKey ( KeyCode.S ) ) 
		{ 
			transform.position += new Vector3( 0f, 0f, -200f ) * Time.deltaTime;
		}

		// move left if I press A
		if ( Input.GetKey ( KeyCode.A ) ) 
		{
			transform.position += new Vector3( -200f, 0f, 0f ) * Time.deltaTime;
		}
		// move right f I press D
		if ( Input.GetKey ( KeyCode.D ) ) 
		{ 
			transform.position += new Vector3( 200f, 0f, 0f ) * Time.deltaTime;
		}


	}
}
