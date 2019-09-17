using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toDisable : Verb
{
    /*
     * This verb will deactivate a target object. 
     */

    //______Variable Declarations_____________________
    public GameObject target;
    //________________________________________________
    public Verb[] triggeredVerbs;

    private void Awake()
    {
        SetAudio();
    }

    // Update is called once per frame
    private void Update()
    {
        //conditional to make sure object is active before setting target object to deactive
        if (isActive)
        {
            //this will end this condition once it passes through a single time
            isActive = false;
            Activate(triggeredVerbs);
            target.SetActive(false);
        }
    }
}

