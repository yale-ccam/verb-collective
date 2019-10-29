/*
 * I forget what Alice drank,
 * or ate,
 * but one made her grow 
 * and the other did this
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toShrink : Verb {



    //Variables required for this verb
    //________________________________

    [Tooltip("Use this to decide how much the object will shrink")]
    public float shrinkMultiplier = 0.5f;

    [Tooltip("Choose how long it will take to shrink")]
    public float duration = 3.0f;

	private float timePassed = 0.0f;
	private Vector3 StartScale;
	private Vector3 FinalScale;

    //_________________________________

    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
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

			if(timePassed >= 1.0f)
			{
                isActive = false;
                CeaseAudio();
                Activate(triggeredVerbs);
			}

            //________________________________
            //________________________________
        }
    }

    //overrides the Conjugate() function in the Verb() class.

    //Unique verb content
    //________________________________
    //________________________________
    override public void Conjugate()
	{
        /*
         * Takes the private variables of StartScale and FinalScale and sets them both
         * before any transforming occurs on the object.
         */
        StartScale = this.transform.localScale;
		FinalScale = StartScale * shrinkMultiplier;
        timePassed = 0.0f;
        PlayAudio();
	}

    //________________________________
    //________________________________
}
/*
 * The object will grow at a variable rate/multiplier for a duratinon of time.
 * User sets the rate and duration.
 * At the start of this activated verb Conjugate() is called to set the target size to shrink to
 */
