/*
 * Like a seed in the ground
 * watered by rain
 * whatever this controls
 * gets bigger by day
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toGrow : Verb {


    //Variables required for this verb
    //________________________________

    [Tooltip("Select how much you want the object to grow")]
    public float growMultiplier = 2.0f;
    [Tooltip("Choose how long you want the growth to take")]
    public float duration = 3.0f;

	private float timePassed;
	private Vector3 StartScale;
	private Vector3 FinalScale;

    //________________________________

    public Verb[] triggeredVerbs;




    private void Start()
    {
        SetAudio();
        // This is used to make sure the change to scale does not reset - see below
        Conjugate();

        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update () {
		if(isActive)
		{

            //Unique verb content
            //________________________________
            //________________________________

            //This will set the scale of the object to a given point between start and final scales
            transform.localScale = Vector3.Lerp(StartScale, FinalScale, timePassed);
			timePassed += Time.deltaTime / duration;

            //________________________________
            //________________________________

            if (timePassed >= 1.0f)
			{
                EndVerb();
                Activate(triggeredVerbs);
			}
		}
	}


    //Unique verb content
    //________________________________
    //________________________________

    //overrides the Conjugate() function in the Verb() class.
    override public void Conjugate () {
        /*
         * Takes the private variables of StartScale and FinalScale and sets them both
         * before any transforming occurs on the object.
         */
		StartScale = this.transform.localScale;
		FinalScale = StartScale * growMultiplier;
		timePassed = 0.0f;
        PlayAudio();
	}
    //________________________________
    //________________________________
}

/*
 * The object will grow at a variable rate/multiplier for a duratinon of time.
 * User sets the rate and duration.
 * At the start of this activated verb Conjugate() is called to calculate the target size to grow towards
 */
