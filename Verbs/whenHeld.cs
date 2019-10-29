/*
 * He's got the whole world in his hands
 * the whole world in his hands
 * 
 * but most of the time
 * it's just one object 
 * and if it is this object,
 * with this verb,
 * ...something might happen...
 * 
 * Note: Requires a trigger object to work
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenHeld : Verb {


    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }

    //Unique verb content
    //________________________________
    //________________________________

    private void OnTriggerEnter(Collider other)
    {
        if (isActive)
        {
            PlayAudio();
            Activate(triggeredVerbs);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isActive)
        {
            CeaseAudio();
            Deactivate(triggeredVerbs);
        }
    }

    //________________________________
    //________________________________

}
/*
* Triggers when trigger object is hit, like pressing a button, onto another object
* Deactivates when object is no longer being hit
* Requires a collider with the isTrigger property set to true
*/
