/*
 * May the force be with you
 * at least for a period of time
 * in the forward direction
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toThrust : Verb
{
    //Variables required for this verb
    //________________________________

    [Tooltip("Determine how powerful the amount of thrust is")]
    public float power = 5.0f;

    [Tooltip("Determine how long the thrust will persist for")]
    public float duration = 3.0f;

    private Rigidbody rb;
    private float timePassed;

    //________________________________

    public Verb[] triggeredVerbs;


    private void Start()
    {
        //Unique verb content
        //________________________________
        //________________________________

        rb = GetComponent<Rigidbody>();

        //________________________________
        //________________________________

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

            rb.AddForce(transform.forward * power);
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
}