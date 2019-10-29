/*
 * Life is a journey
 * that begins with a single step
 * so...
 * Use this verb
 * and enjoy the journey
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toStep : Verb
{
    //Variables required for this verb
    //________________________________

    [Tooltip("Determine how fast you want the object to move")]
    public float rate = 1.0f;

    [Tooltip("Choose how long you want the object to be moving")]
    public float duration = 3.0f;

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

            transform.position += transform.forward * rate * Time.deltaTime;
            timePassed += Time.deltaTime / duration;

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
 * This is a simple verb to move things forward.
 */
