using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenHit : Verb {

   /*
   * Triggers when object collides with another object
   * Requires a collider with the isTrigger property set to false
   */

    //______Variable Declarations_____________________
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
