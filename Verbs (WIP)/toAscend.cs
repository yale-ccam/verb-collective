using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toAscend : Verb {


	public float rate = 1.0f;
	public float maxHeight = 20.0f;
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
			
			transform.position += Vector3.up * rate * Time.deltaTime;

			if(transform.position.y >= maxHeight){
				EndVerb();
                Activate(triggeredVerbs);
			}
		}
	}
}
