using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toHit : Verb {

    public Verb[] triggeredVerbs;

    private void Awake()
    {
        //Helper Function to Set up Audio Source tied to Verb
        SetAudio();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isActive)
        {
            //Plays audio and activates triggered Verbs upon collision
            PlayAudio();
            Activate(triggeredVerbs);
        }
    }
}
