using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toWait : Verb {

    /*
     * Object will stay and wait for a duration of time
     * The user can provide the duration or it will be set to 3 as default.
     */

    //______Variable Declarations_____________________
    public float duration = 3.0f;
    //________________________________________________
	public Verb[] triggeredVerbs;

	private float timePassed;

	void Awake () {
		SetAudio();
		Conjugate();
	}

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update () {
		if(isActive)
		{
            //Time.deltaTime will increase the timePassed variable by time units instead of frames.
			timePassed += Time.deltaTime;

			if(timePassed >= duration)
			{
				isActive = false;
                CeaseAudio();
                Activate(triggeredVerbs);
			}
		}
	}

    //overrides the Conjugate() function in the Verb() class.
	override public void Conjugate () {
		timePassed = 0.0f;
        base.Conjugate();
	}
}
