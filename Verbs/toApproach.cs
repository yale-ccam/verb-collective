using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toApproach : Verb {

	//Variable Declarations
	public float speed = 1.0f;
	public Vector3 targetPos;
	public Verb[] triggeredVerbs;


	void Awake () {
		//Helper function to set up the Audio Source tied to the verb
		SetAudio();
	}

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    void Update () {
		if(isActive)
		{
			//The Action of the Verb, what does it do?

			var step = Time.deltaTime * speed;
			transform.position = Vector3.MoveTowards(transform.position, targetPos, step);

			//Termination condition, when does it stop?
			if(transform.position == targetPos){

				//Functions to End the Verb as well as signal the triggeredVerbs to activate
				EndVerb();
                Activate(triggeredVerbs);
			}
		}
	}
}
