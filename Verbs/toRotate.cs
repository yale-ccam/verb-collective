using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRotate : Verb
{
    /*
     * The object will spin in place at a variable speed for a duration of time set on an axis.
     * The user will input the speed(degreesPerSecond), axis, and duration.
     * axis is set at a default of Vector3.up, but can be changed in the Unity Editor
     */

    //______Variable Declarations_____________________
    public Vector3 axis = Vector3.up;
    public float degreesPerSecond = 1.0f;
    public float duration;
    //________________________________________________
    public Verb[] triggeredVerbs;

    private float timeRunning = 0.0f;

    void Awake()
    {
        SetAudio();
    }

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            //Object will rotate against three variables, current position, user provided axis,
            //and user provided degreesPerSecond. Time.deltaTime makes the motion smooth.
            transform.RotateAround(transform.position, axis, degreesPerSecond * Time.deltaTime);
            timeRunning += Time.deltaTime;

            if (timeRunning > duration)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }
        }
    }

    //overrides the Conjugate() function in the Verb() class.
    override public void Conjugate()
    {
        //added a line to have timeRunning set to 0 before the start of the rotation.
        timeRunning = 0.0f;
        PlayAudio();
    }
}
