/*
 * Its coming 
 * almost there
 * just a sec
 * a little more
 * hold for it
 * keep holding...
 * 
 * Waiting can be hard to do
 * but not with this!
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toWait : Verb {



    //______Variable Declarations_____________________
    public float duration = 3.0f;
    //________________________________________________
	public Verb[] triggeredVerbs;

	private float timePassed;



    private void Start()
    {
        SetAudio();

        //Unique verb content
        //________________________________
        //________________________________

        Conjugate();

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

            //Time.deltaTime will increase the timePassed variable by time units instead of frames.
            timePassed += Time.deltaTime;

			if(timePassed >= duration)
			{
				isActive = false;
                CeaseAudio();
                Activate(triggeredVerbs);
			}

            //________________________________
            //________________________________
        }
    }
    //Unique verb content
    //________________________________
    //________________________________

    //overrides the Conjugate() function in the Verb() class.
    override public void Conjugate () {
		timePassed = 0.0f;
        base.Conjugate();
	}

    //________________________________
    //________________________________
}

/*
 * Object will stay and wait for a duration of time
 * The user can provide the duration or it will be set to 3 as default.
 * This is useful for timing interactions and creating delays
 * Sometimes having a half second between functions helps avoid confusion
 */
