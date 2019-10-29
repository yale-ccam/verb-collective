/*
* Just a gentle nudge will do
* tap, tickle, or touch 
* no matter how little 
* it does just as much
* 
* note: needs isTrigger active
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenTouched : Verb {


    //Variables required for this verb
    //________________________________

    [Tooltip("Turn this on if you only want the effect to happen once")]
    public bool deactivateOnTouch;
    
    //________________________________
    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }

    //Unique verb content
    //________________________________
    //________________________________

    // Checks to see if object hits another object
    private void OnTriggerEnter(Collider other)
    {
        if(isActive){
            PlayAudio();
            Activate(triggeredVerbs);

            if(deactivateOnTouch)
                isActive = false;
          }
    }

    //________________________________
    //________________________________
}
/*
* Triggers when object collides with another object
* User provides whether this objcet will deactive on touch
*/
