using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toFall : Verb{

  /*
   *  Object will move down on the y-axis at a variable speed to a minimum height.
   * The speed and height are the main variables for this verb.
   * The verb will end when the object reaches or falls below the minimum height.
   * This verb utilizes Unity's physics engine and requires a Rigidbody
   */

    public float rate = 1.0f;
	public float minHeight = 0.0f;
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
			rb.MovePosition(transform.position - (Vector3.up * rate * Time.fixedDeltaTime));

			if(transform.position.y <= minHeight){
				EndVerb();
                Activate(triggeredVerbs);
			}
		}
	}
}
