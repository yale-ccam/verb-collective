using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenStill : Verb {

    /*
	* Triggers when object remains motionless for a duration of time
    * User provides the threshold for an object to remain still
    */

    //______Variable Declarations_____________________
    public int stillThreshold = 100;
    //________________________________________________
	public Verb[] triggeredVerbs;

    private int framesStill = 0;

    private void Awake()
    {
        SetAudio();
    }

    void Update()
    {
        if (isActive)
        {
            // if movement occurs the trigger will be reset to 0
            if (transform.hasChanged)
            {
                framesStill = 0;
                transform.hasChanged = false;
            }
            else
            {

                if (framesStill == stillThreshold)
                {
                    PlayAudio();
                    framesStill += 1;
                    Activate(triggeredVerbs);
                }
                else if(framesStill < stillThreshold)
                {
                    framesStill += 1;
                }
            }
        }
    }
}
