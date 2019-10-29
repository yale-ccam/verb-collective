/*
 * Copy and paste this for quick verb making
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class toSample : Verb
{

    //Variables required for this verb
    //________________________________

    //[Tooltip("Tell users what this vartiable does")]

    //______________________________

    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
        if (isActive)
            PlayAudio();
    }
    
    void Update()
    {
        if (isActive)
        {      
            //Unique verb content
            //________________________________
            //________________________________

            Debug.Log("I am");

            //________________________________
            //________________________________

            //Remove comments below to enable a conditional statement for ending the verb
            // if ()
            //{         
                EndVerb();
                Activate(triggeredVerbs);
            //}
        }
    }
}
/*
 * Copy and paste this for quick verb making
 */
