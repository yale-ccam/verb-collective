/*
 *  What goes up
 *  must come down
 *  which is where things go
 *  when this verb is around
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class toDescend : Verb {



    //Variables required for this verb
    //________________________________

    [Tooltip("This is the speed at which the object will move")]
    public float rate = 1.0f;

    [Tooltip("This is the depth that the object will move to")]
    public float minHeight = -20.0f;

    //Because this verb uses physics it needs a rigidbody on the object
    private Rigidbody rb;

    //________________________________

    public Verb[] triggeredVerbs;




    private void Start()
    {
        SetAudio();
        //rb = GetComponent<Rigidbody>();

        if (isActive)
            PlayAudio();
    }

    //FixedUpdate is used when objects are given Rigidbody in Unity
  
    void FixedUpdate () {
		if(isActive)
		{
            /*Time.deltaTime converts speed from per frame to per time. Makes motion smooth.
            *Object will update based off direction(Vector3.up) and speed(rate)
            *Vector3.down is shorthand. You can replace up with right, left, or down to change direction.
            ________________________________________________*/

            //rb.MovePosition(transform.position + (Vector3.down * rate * Time.deltaTime));

            //Unique verb content
            //________________________________
            //________________________________

            transform.position += Vector3.down * rate * Time.deltaTime;

			if(transform.position.y <= minHeight){

                EndVerb();
				Activate(triggeredVerbs);
			}
            
            //________________________________
            //________________________________
        }
    }
}

/*
 *  Object will move down on the y-axis at a variable speed to a minimum height. 
 * The speed and height are the main variables for this verb. 
 * The verb will end when the object reaches or falls below the minimum height.
 */
