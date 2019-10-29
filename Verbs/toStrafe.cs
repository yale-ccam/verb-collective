/*
 * To the left
 * to the right
 * to the left 
 * to the right
 * 
 * This isnt a dance 
 * you get to decide
 * pick a direction 
 * to get there in time
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toStrafe : Verb
{

    //Variables required for this verb
    //________________________________

    [Tooltip("Choose the speed of movement")]
    public float rate = 1.0f;  

    [Tooltip("Determine how long the object will move")]
    public float duration = 3.0f; 


    [Tooltip("Turn this on to move left")]
    public bool MoveRight = true; 

    [Tooltip("Turn this on to move right")]
    public bool MoveLeft = false; 

    private float timePassed; 

    //________________________________


    public Verb[] triggeredVerbs;


    private void Start()
    {
        SetAudio();

        if (isActive)
            PlayAudio();
    }

    void FixedUpdate()
    {
        if (isActive)
        {

            //Unique verb content
            //________________________________
            //________________________________
            
            if (MoveRight)
            {      
                transform.position += transform.right * rate * Time.deltaTime;
                timePassed += Time.deltaTime / duration;
            }

            if (MoveLeft)
            {
                transform.position -= transform.right * rate * Time.deltaTime;
                timePassed += Time.deltaTime / duration;
            }

            if (timePassed >= 1.0f)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }

            //________________________________
            //________________________________
        }
    }

    //Unique verb content
    //________________________________
    //________________________________
    override public void Conjugate()
    {
        timePassed = 0.0f;
        PlayAudio();
    }
    //________________________________
    //________________________________
}
/*
 * This verb is used to move things sideways.  It is useful for creating simple controllers.
 */
