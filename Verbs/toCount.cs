using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toCount : Verb
{
    /*
     * A simple verb that counts from a currentNumber value to a user provided targetNumber
     * Useful when you want an event to happen after a certain number of user actions
     * User can also set the speed(rate) at which the count takes place.
     */

    //______Variable Declarations_____________________
    public float rate = 1.0f;
	public float targetNumber = 5.0f;
    //________________________________________________

    //SerializeField is just making this private variable, below, visible in the Unity Editor.
	[SerializeField]
	private float currentNumber = 0.0f;

	public Verb[] triggeredVerbs;

	void Awake ()
	{
		SetAudio();
	}

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // FixedUpdate is called once per frame
    void FixedUpdate () {
		if(isActive)
		{
			//An incrementation of the currentNumber based on the user defined rate variable.
			currentNumber += rate;

			if(currentNumber >= targetNumber)
				{
                //when the targetNumber is reached or exceeded, the currentNumber will be set back to 0
				currentNumber = 0.0f;
				EndVerb();
                Activate(triggeredVerbs);
				}
			else{
				isActive = false;
				}
		}
	}
}
