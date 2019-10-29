/*
 * Righty tighty
 * Lefty loosey
 * as long as it spins
 * this verb is happy
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRotate : Verb
{


    //Variables required for this verb
    //________________________________

    [Tooltip("Choose a number between 0 and 1 for each axis, with a higher number being used to select the axis for rotation")]
    public Vector3 axis = Vector3.up;

    [Tooltip("This determines the speed at which it will rotate")]
    public float degreesPerSecond = 1.0f;

    [Tooltip("Choose how long it rotate for")]
    public float duration;

    private float timeRunning = 0.0f;
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

            //Object will rotate against three variables, current position, user provided axis,
            //and user provided degreesPerSecond. Time.deltaTime makes the motion smooth.
            transform.RotateAround(transform.position, axis, degreesPerSecond * Time.deltaTime);
            timeRunning += Time.deltaTime;

            if (timeRunning > duration)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }

            //________________________________
            //________________________________
        }
    }

    //overrides the Conjugate() function in the Verb() class.
    override public void Conjugate()
    {
        timeRunning = 0.0f;
        PlayAudio();
    }
}
/*
 * The object will spin in place at a variable speed for a duration of time set on an axis.
 * The user will input the speed(degreesPerSecond), axis, and duration.
 * axis is set at a default of Vector3.up, but can be changed in the Unity Editor
 */
