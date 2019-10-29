/*
 * It isnt always love at first sight
 * sometimes it takes
 * one or two or even three times
 * 
 * If you want something to happen 
 * but want to make someone work
 * use this to test if they are willing to try
 * one or two or even three times
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toCount : Verb
{

    //Variables required for this verb
    //________________________________

    [Tooltip("Choose what increment count in, if not one")]
    public float rate = 1.0f;
    [Tooltip("Choose how high you want to count to before the verbs trigger")]
    public float targetNumber = 5.0f;

    //SerializeField is just making this private variable, below, visible in the Unity Editor.
    [SerializeField]
    [Tooltip("This is just here so you can see the current count in the editor view")]
    private float currentNumber = 0.0f;

    //________________________________

	public Verb[] triggeredVerbs;



    private void Start()
    {
        SetAudio();

        if (isActive)
            PlayAudio();
    }

    // FixedUpdate is called once per frame
    void FixedUpdate () {
		if(isActive)
		{

            //Unique verb content
            //________________________________
            //________________________________

            //An incrementation of the currentNumber based on the user defined rate variable.
            currentNumber += rate;

			if(currentNumber >= targetNumber)
			{
                //when the targetNumber is reached or exceeded, the currentNumber will be set back to 0
				currentNumber = 0.0f;
				EndVerb();
                Activate(triggeredVerbs);
			}

			else
            {
				isActive = false;
			}

            //________________________________
            //________________________________

        }
    }
}
/*
 * A simple verb that counts from a currentNumber value to a user provided targetNumber
 * Useful when you want an event to happen after a certain number of user actions
 * User can also set the speed(rate) at which the count takes place.
 */
