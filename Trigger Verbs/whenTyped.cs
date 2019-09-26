using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenTyped : Verb {

    /*
	  * Triggers when the user presses a key 
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
            if (Input.GetKeyDown(keyCode))
            {
                PlayAudio();
                Activate(triggeredVerbs);
            }
        }
	}
}
