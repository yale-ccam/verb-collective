/*
 * What is not dead
 * but is not alive?
 * What has weight 
 * but weighs nothing
 * has color 
 * but cannot be seen?
 * 
 * answer: 
 * The object that was disabled
 * before you triggered this verb
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toEnable : Verb
{


    //Variables required for this verb
    //________________________________

    [Tooltip("Drag the gameobject you want to enable here")]
    public GameObject target;
    
    //________________________________

    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }

    private void Update()
    {
        if (isActive)
        {
            EndVerb();

            //Unique verb content
            //________________________________
            //________________________________

            target.SetActive(true);
            
            //________________________________
            //________________________________
        }
    }
}
/*
 * This verb will make the target object active.
 */
