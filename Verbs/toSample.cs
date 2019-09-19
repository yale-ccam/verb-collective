using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When you create a new verb the name of it will replace "toSample"
public class toSample : Verb
{

    //Variable Declarations
    //You can place your public variables below
    
    //______________________________
    // The line below is necessary to call other Verbs
    public Verb[] triggeredVerbs;

    //This is called before the start of the verb. Useful for setting any values before transformations
    void Awake()
    {
        //Helper function to set up the Audio Source tied to the verb
        SetAudio();
    }

    //Your Verb needs this to being. Do not remove.
    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    //Your Verb will update every frame with this function. This is very important and should not be removed.
    void Update()
    {
        if (isActive)
        {
            //The Action of the Verb, what does it do?

           
            //Termination condition, when does it stop?
            //The following if statement is an example and should be repalced to match your desired action
            if (transform.position == targetPos)
            {

                //Functions to End the Verb as well as signal the triggeredVerbs to activate
                EndVerb();
                Activate(triggeredVerbs);
            }
        }
    }
}
