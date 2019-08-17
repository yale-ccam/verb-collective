using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRise : Verb
{
    public float rate = 1.0f;
	public float maxHeight = 20.0f;
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
			rb.MovePosition(transform.position + (Vector3.up * rate * Time.fixedDeltaTime));

			if(transform.position.y >= maxHeight){
				EndVerb();
                Activate(triggeredVerbs);
			}
		}
	}
}
