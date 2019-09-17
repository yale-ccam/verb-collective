using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toEnable : Verb
{
    /*
     * This verb will make the target object active.
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
        //Checks the active state of the object. If active will set the target object to active.
        if (isActive)
        {
            EndVerb();
            target.SetActive(true);
        }
    }
}
