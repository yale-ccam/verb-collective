/*
 * Im against murder
 * and violence of all kinds
 * so it pains me to have this
 * seriously, I want to be more creative
 * but...
 * people are going to want this...
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toKill : Verb
{
    //Variables required for this verb
    //________________________________

    [Tooltip("Drag the gameobject you want to destroy here")]
    public GameObject victim;
 
    //________________________________

    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }

    // Update is called once per frame
    private void Update()
    {
        if (isActive)
        {
            Activate(triggeredVerbs);

            //Unique verb content
            //________________________________
            //________________________________

            Destroy(victim);

            //________________________________
            //________________________________
        }
    }
}
/*
 * The object subject to this verb will be destroyed, or removed from the scene.
 */
