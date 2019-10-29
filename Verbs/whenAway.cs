/*
* Absence 
* makes the heart grow fonder
* Distance 
* just triggers this verb
* 
* note: The difference between this 
* and whenDistant is that this uses
* a set of coordinates, while whenDistant
* uses a reference object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenAway : Verb {


    //Variables required for this verb
    //________________________________

    [Tooltip("This determines the location being referenced by the script, blank is simply your starting position")]
    public Vector3 point;

    [Tooltip("This determines how far away you need to be in order to trigger the script")]
    public float threshold;

    [Tooltip("Turn this on to invert the script and have it test to see if you are close enough to the reference location")]
    public bool triggerWhenNear;

    [Tooltip("Turn this on if you only want the trigger to activate a single time")]
    public bool triggerOnlyOnce;

	private bool pastState = false;

    //________________________________


    public Verb[] triggeredVerbs;


    private void Start()
    {
        SetAudio();
    }

    // Update is called once per frame
    void Update () {

        if (isActive)
        {

            //Unique verb content
            //________________________________
            //________________________________

            // ^ is an operand for XOR, so if this exceeds the threshold or the triggerWhenNear value
            if (Vector3.Distance(transform.position, point) > threshold ^ triggerWhenNear)
            {
                if (!pastState)
                {
                    PlayAudio();
                    Debug.Log("play here");
                    Activate(triggeredVerbs);

                    if (triggerOnlyOnce)
                    {
                        Destroy(this);
                    }
                    pastState = true;
                }
            }
            else
            {
                if (pastState)
                {
                    CeaseAudio();
                    Deactivate(triggeredVerbs);
                    pastState = false;
                }
            }

            //________________________________
            //________________________________
        }
    }
}
/*
* Triggers if the object is over distance from point
* point can either be set in inspector or will default to the starting point.
* User can provide the threshold and the location(point).
* User can provide the option of this trigger occuring due to proximity and/or only triggering once.
*/
