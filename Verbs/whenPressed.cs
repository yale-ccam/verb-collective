using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenPressed : Verb {

    /*
	  * Triggers for the duration that a key is held down
    * Deactivates when the key is no longer pressed 
    * User provides the key to be pressed
    */

    //______Variable Declarations_____________________
    public string keyCode;
    //________________________________________________
	public Verb[] triggeredVerbs;

    private void Awake()
    {
        SetAudio();
    }

    void Update ()
	{
        if (isActive)
        {
            // Will stop triggered verbs if the button is no longer being pressed
            if (Input.GetKeyDown(keyCode))
            {
                PlayAudio();
                Activate(triggeredVerbs);
            }
            else if (Input.GetKeyUp(keyCode))
            {
                CeaseAudio();
                Deactivate(triggeredVerbs);
            }
        }
	}
}
