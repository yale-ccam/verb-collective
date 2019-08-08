using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toStill : Verb {

	public int stillThreshold = 100;
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
