/*
 * If you want to move
 * towards some distant point
 * this works to send things
 * wherever you want
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toApproach : Verb
{


    //Variables required for this verb
    //________________________________

    [Tooltip("Choose how fast the object will move")]
    public float speed = 1.0f;

    [Tooltip("Choose the coordinates the object will move towards")]
    public Vector3 targetPos;

    //________________________________

    public Verb[] triggeredVerbs;



    private void Start()
    {
        SetAudio();

        if (isActive)
            PlayAudio();
    }

 
    void Update()
    {
        if (isActive)
        {

            
            //Unique verb content
            //________________________________
            //________________________________

           /*
            * Time.deltaTime converts speed from per frame to per time. Makes motion smooth.
            *Object will update based off the target location(targetPos), speed(step)
            *and current position(transform.position).
            */ 

            var step = Time.deltaTime * speed;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);

            if (transform.position == targetPos)
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
 * Object will move towards a target location at a variable speed. 
 * The speed and location are the main variables for this verb. 
 * The verb will end when the object reaches the target location.
 */
