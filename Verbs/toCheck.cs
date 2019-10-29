/*
 * Sometimes im willing 
 * to do something for you
 * but I like to make sure
 * that you're really you
 * 
 * If you are the one
 * Then you have the right name
 * otherwise just forget it
 * I wont do a thing
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toCheck : Verb
{

    //Variables required for this verb
    //________________________________

    [Tooltip("Turn this on if you only want the verb to happen once")]
    public bool deactivateOnTouch;

    [Tooltip("Correctly type the name of the tag you want to test for")]
    public string tagBeingChecked = "Player";

    //_______________________________


    public Verb[] triggeredVerbs;


    private void Start()
    {
        SetAudio();
    }


    //Unique verb content
    //________________________________
    //________________________________

    // Checks to see if object hits another object
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagBeingChecked)
        {
            if (isActive)
            {
                PlayAudio();
                Activate(triggeredVerbs);

                if (deactivateOnTouch)
                    isActive = false;
            }
        }
    }
    //________________________________
    //________________________________
}

/*
 * This verb looks for trigger collisions 
 * and will then trigger verbs if the triggering object has the correct tag
 */
