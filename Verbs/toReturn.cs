/*
 * Home is where the heart is
 * and as far as you go
 * you can always go home
 * 
 * This verb brings you back
 * to where you began
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toReturn : Verb {

    //Variables required for this verb
    //________________________________

    [Tooltip("Choose how fast you want it to return to the origin")]
    public float returnRate = 5.0f;

    private float startTime;
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    //_________________________________

    public Verb[] triggeredVerbs;


    private void Start()
    {
        SetAudio();

        //Unique verb content
        //________________________________
        //________________________________

        //Sets both startingPosition and startingRotation before any transformations occur
        startingPosition = this.transform.position;
        startingRotation = this.transform.rotation;
        this.isActive = false;

        //________________________________
        //________________________________

        if (isActive)
            PlayAudio();
    }

    void Update () {
		if(isActive)
		{
            //Unique verb content
            //________________________________
            //________________________________

            //Multiplying by Time.detlaTime allows for smooth movement
            float step = returnRate * Time.deltaTime;
            //Updates the position of the object to move closer to the place of origin(startingPosition)
            transform.position = Vector3.MoveTowards(transform.position, startingPosition, step);
            //Keeps the object from rotating beyond the scope of the target object
            transform.rotation = Quaternion.RotateTowards(transform.rotation, startingRotation, 30.0f * step);

            if (this.transform.position == startingPosition && this.transform.rotation == startingRotation)
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
 * Object will return to place of origin when triggered at a variable speed.
 * User can input the speed(returnRate). 
 */
