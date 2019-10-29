/*
 * Green lights are fine
 * yellow ones too
 * but I go for red
 * and this verb does too
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toStop : Verb {

    //Variables required for this verb
    //________________________________

    [Tooltip("Drag here the gameobject for which you want to stop all the verbs")]
    public GameObject ObjectToStop;

    //________________________________

    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();

        if (isActive)
            PlayAudio();
    }


    void Update () {
        if (isActive)
        {
            isActive = false;

            //Unique verb content
            //________________________________
            //________________________________

            Deactivate(ObjectToStop.GetComponents<Verb>());

            //________________________________
            //________________________________
            EndVerb();
            Activate(triggeredVerbs);

        }
	}
}
/*
 * This verb will stop all actions on an object. It will stop
 * all active verbs
 */
