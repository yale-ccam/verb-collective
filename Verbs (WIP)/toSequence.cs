using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSequence : Verb
{
    public bool randomize;

	[SerializeField]
	private int currentNumber = 0;

	[SerializeField]
	private int numberOfSteps;
	
	public Verb[] triggeredVerbs;


	void Awake () 
	{
		SetAudio();
		numberOfSteps = triggeredVerbs.Length;

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

    void FixedUpdate () {
		if(isActive && numberOfSteps != 0)
		{
			EndVerb();
            Activate(triggeredVerbs[currentNumber]);

            if(randomize){
            	int next = Random.Range(0, numberOfSteps);
				currentNumber = (next == currentNumber)? ((next + 1) % numberOfSteps) : next;
			}
			else{
				currentNumber = (currentNumber + 1) % numberOfSteps;
			}
        }
	}
}
