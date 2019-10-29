/*
 * Language is lovely
 * special and fine
 * but I can do more
 * when the letters are mine
 * 
 * Whatever you type
 * any letter can do
 * changes the world
 * I do that for you
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenTyped : Verb {


    //Variables required for this verb
    //________________________________

    [Tooltip("Type the name of the key you want to act as a trigger - example 1: a example 2: space - see https://docs.unity3d.com/ScriptReference/KeyCode.html for more options")]
    public string keyCode;

    //________________________________

    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }

    void Update ()
	{
        if (isActive)
        {
            //Unique verb content
            //________________________________
            //________________________________

            if (Input.GetKeyDown(keyCode))
            {
                PlayAudio();
                Activate(triggeredVerbs);
            }

            //________________________________
            //________________________________
        }
    }
}
/*
 * Triggers when the user types a key 
 * User provides the keycode
 */
