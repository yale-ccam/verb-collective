/*
 * one step forward 
 * and then two of these
 * I will move backwards
 * quick as you please
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toBackstep : Verb
{

    //Variables required for this verb
    //________________________________
    [Tooltip("Choose how fast the object will move")]
    public float rate = 1.0f;

    [Tooltip("Choose how long the movement will last")]
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

            transform.position -= transform.forward * rate * Time.deltaTime;
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