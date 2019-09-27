using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenTouched : Verb {

    /*
	* Triggers when object collides with another object
    * User provides whether this objcet will deactive on touch
    */

    //______Variable Declarations_____________________
    //a variable that works like a true/false statement to determine if object becomes inactive.
    public bool deactivateOnTouch;
    //________________________________________________
    public Verb[] triggeredVerbs;

    private void Awake()
    {
        SetAudio();
    }

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
}
