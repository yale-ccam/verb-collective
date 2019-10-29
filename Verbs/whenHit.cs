/*
 * Ouch! 
 * It isnt nice to hit people,
 * or things,
 * but sometimes it happens
 * and when it does
 * it can trigger some verbs
 * 
 * note: Rigidbody should not be set to isTrigger
 */ 
   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenHit : Verb {




    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }

    //Unique verb content
    //________________________________
    //________________________________

    private void OnCollisionEnter(Collision collision)
    {
        if (isActive)
        {
            //Plays audio and activates triggered Verbs upon collision
            PlayAudio();
            Activate(triggeredVerbs);
        }
    }
    //________________________________
    //________________________________
}
/*
* Triggers when object collides with another object
* Requires a collider with the isTrigger property set to false
*/
