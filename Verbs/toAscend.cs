/*
 * Heat rises up
 * up to towards the sky
 * when this gets triggered
 * so do I
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toAscend : Verb {



    //Variables required for this verb
    //________________________________

    [Tooltip("Choose how fast the object will rise")]
    public float rate = 1.0f;

    [Tooltip("Choose how far the object will move")]
    public float maxHeight = 20.0f;

    //________________________________
    public Verb[] triggeredVerbs;


    private void Start()
    {
        SetAudio();

        if (isActive)
            PlayAudio();
    }

    //FixedUpdate is used when objects are given Rigidbody in Unity
    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        if (isActive)
        {
            /*Time.deltaTime converts speed from per frame to per time. Makes motion smooth.
            *Object will update based off direction(Vector3.up) and speed(rate)
            *Vector3.up is shorthand. You can replace up with right, left, or down to change direction.
            ________________________________________________*/

            //Unique verb content
            //________________________________
            //________________________________

            transform.position += Vector3.up * rate * Time.deltaTime;
            
            if (transform.position.y >= maxHeight)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }

            //________________________________
            //________________________________
        }
    }
}
/*
 * Object will move up on the y-axis at a variable speed to a max height. 
 * The speed and height are the main variables for this verb. 
 * The verb will end when the object reaches or exceeds the max height.
 */
