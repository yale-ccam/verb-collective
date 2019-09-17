using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSequence : Verb
{
    /* 
     * 
     */

    //______Variable Declarations_____________________
    //a variable that works like a true/false statement to determine if sequence shoudl be random.
    public bool randomize;
    //_________________________________________________

    //SerializeField is just making this private variable, below, visible in the Unity Editor.
    [SerializeField]
	private int currentNumber = 0;

	[SerializeField]
	private int numberOfSteps;
	
	public Verb[] triggeredVerbs;


	void Awake () 
	{
		SetAudio();
        //checks the verb toSequence() to check how many trigger verbs are currently in the list.
		numberOfSteps = triggeredVerbs.Length;

        //if boolean is true, the starting point for the sequence will be set to random between 0
        //and the total number of triggeredVerbs
		if(randomize)
		{
			currentNumber = Random.Range(0, numberOfSteps);
		}
	}

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // FixedUpdate is called once per frame
    void FixedUpdate () {
		if(isActive && numberOfSteps != 0)
		{
			EndVerb();
            Activate(triggeredVerbs[currentNumber]);

            if(randomize){
            	int next = Random.Range(0, numberOfSteps);
                // the ? and : in this statement are part of a ternary operator
                // Condition? If true : If false
                currentNumber = (next == currentNumber)? ((next + 1) % numberOfSteps) : next;
			}
			else{
				currentNumber = (currentNumber + 1) % numberOfSteps;
			}
        }
	}
}
