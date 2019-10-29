/*
 * Please don't die
 * but do go away
 * come back if I need you
 * on some other day 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toDisable : Verb
{


    //Variables required for this verb
    //________________________________

    [Tooltip("Drag the gameobject you want to disable here")]
    public GameObject target;

    //________________________________

    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }


    private void Update()
    {
        //conditional to make sure object is active before setting target object to deactive
        if (isActive)
        {
            

            //this will end this condition once it passes through a single time
            isActive = false;
            Activate(triggeredVerbs);

            //Unique verb content
            //________________________________
            //________________________________

            target.SetActive(false);

            //________________________________
            //________________________________

        }
    }
}
/*
 * This verb will deactivate a target object.
 * Deactivated objects are still present in the scene but are invisible and inactive while deactivated
 */
