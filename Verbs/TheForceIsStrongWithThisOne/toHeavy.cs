﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toHeavy : Verb
{
  /*
   *  Increases the mass on a rigdibody to make objects "heavier" in Unity's physics engine
   * Requires a Rigidbody
   */

    public float rate = 1.0f;
	public Verb[] triggeredVerbs;

	private Rigidbody rb;

	void Awake ()
	{
		SetAudio();
	}

    private void Start()
    {
    	rb = GetComponent<Rigidbody>();
    	rb.isKinematic = true;

        if (isActive)
            PlayAudio();
    }

    void FixedUpdate () {
		if(isActive)
		{
			rb.mass *= rate;
			EndVerb();
            Activate(triggeredVerbs);

		}
	}
}
