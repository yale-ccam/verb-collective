using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toReturn : Verb {

    /*
     * Object will return to place of origin when triggered at a variable speed.
     * User can input the speed(returnRate). 
     */

    //______Variable Declarations_____________________
    public float returnRate = 5.0f;
    //________________________________________________
    public Verb[] triggeredVerbs;

    private float startTime;
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    void Awake()
    {
        SetAudio();
        //Sets both startingPosition and startingRotation before any transformations occur
        startingPosition = this.transform.position;
        startingRotation = this.transform.rotation;
        this.isActive = false;
    }

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    void Update () {
		if(isActive)
		{
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
        }
	}
}
