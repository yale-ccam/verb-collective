/*
* Motion gets all the love
* everyone wants to move
* but if you can handle stillness
* this verb will play your tune
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenStill : Verb {

    //Variables required for this verb
    //________________________________

    [Tooltip("How long should the object remain still before triggering any effects")]
    public int stillThreshold = 100;

    private int framesStill = 0;

    //________________________________

    public Verb[] triggeredVerbs;


    private void Start()
    {
        SetAudio();
    }

    void Update()
    {
        if (isActive)
        {
            //Unique verb content
            //________________________________
            //________________________________

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
            //________________________________
            //________________________________
        }
    }
}
/*
* Triggers when object remains motionless for a duration of time
* User provides the threshold for an object to remain still
*/
