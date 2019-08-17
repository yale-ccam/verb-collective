using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toCount : Verb
{
    public float rate = 1.0f;
	public float targetNumber = 5.0f;

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

    void FixedUpdate () {
		if(isActive)
		{
			
			currentNumber += rate;

			if(currentNumber >= targetNumber)
				{
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
