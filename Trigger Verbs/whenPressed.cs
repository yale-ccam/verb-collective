using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenPressed : Verb {

	//triggers for the duration that the object is being touched
	public string keyCode;
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
            else if (Input.GetKeyUp(keyCode))
            {
                CeaseAudio();
                Deactivate(triggeredVerbs);
            }
        }
	}
}
