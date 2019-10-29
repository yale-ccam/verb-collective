/*
* Some things happen once
* some a little at a time
* as long as this key is down
* a little works just fine
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenPressed : Verb {

    //Variables required for this verb
    //________________________________

    [Tooltip("Type the name of the key you want to act as a trigger - example 1: a example 2: space - see https://docs.unity3d.com/ScriptReference/KeyCode.html for more options")]
    public string keyCode;

    //Variables required for this verb
    //________________________________
    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }

    void Update ()
	{
        if (isActive)
        {
            //Unique verb content
            //________________________________
            //________________________________

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

            //Unique verb content
            //________________________________
            //________________________________
        }
    }
}
/*
* Triggers for the duration that a key is held down
* Deactivates when the key is no longer pressed 
* User provides the key to be pressed
*/
