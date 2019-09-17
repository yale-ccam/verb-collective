using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class toDescend : Verb {

    /*
     *  Object will move down on the y-axis at a variable speed to a minimum height. 
     * The speed and height are the main variables for this verb. 
     * The verb will end when the object reaches or falls below the minimum height.
     */

    //______Variable Declarations_____________________
    public float rate = 1.0f;
	public float minHeight = -20.0f;
    //________________________________________________
	public Verb[] triggeredVerbs;

    private Rigidbody rb;
	void Awake () {

		SetAudio();
        //rb = GetComponent<Rigidbody>();
	}

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    //FixedUpdate is used when objects are given Rigidbody in Unity
    // FixedUpdate is called once per frame
    void FixedUpdate () {
		if(isActive)
		{
            /*Time.deltaTime converts speed from per frame to per time. Makes motion smooth.
            *Object will update based off direction(Vector3.up) and speed(rate)
            *Vector3.down is shorthand. You can replace up with right, left, or down to change direction.
            ________________________________________________*/

            //rb.MovePosition(transform.position + (Vector3.down * rate * Time.deltaTime));
            transform.position += Vector3.down * rate * Time.deltaTime;
            //________________________________________________

			if(transform.position.y <= minHeight){

                EndVerb();
				Activate(triggeredVerbs);
			}
		}
	}
}
 