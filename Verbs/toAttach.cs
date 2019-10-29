/*
 * What do you know
 * you can't remember that night
 * it was so long ago 
 * so maybe I'm right
 * this will prove Im your child
 * and then you will see
 * wherever you go
 * there I will be 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toAttach : Verb
{


    //Variables required for this verb
    //________________________________

    [Tooltip("Drag a gameobject here to make this object it's child")]
    public Transform target;


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
            //Unique verb content
            //________________________________
            //________________________________

            transform.SetParent(target);

            //________________________________
            //________________________________
            EndVerb();
            Activate(triggeredVerbs);
        }
    }
}

/*
 * Object will be attached to a target object by making it a child of the target.
 * Making this Verb useful for combining objects
 */
