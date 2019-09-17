using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toAttach : Verb
{
    /*
     * Object will be attached to a target object by making it a child of the target.
     * Making this Verb useful for combining objects
     */

    //______Variable Declarations_____________________
    public Transform target;
    //________________________________________________
    public Verb[] triggeredVerbs;

    private void Awake()
    {
        SetAudio();
    }

    // Update is called once per frame
    private void Update()
    {
        if (isActive)
        {
            //transform object into child of target
        	transform.SetParent(target);
            EndVerb();
            Activate(triggeredVerbs);
        }
    }
}
