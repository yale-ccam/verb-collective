using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class toDescend : Verb {

	public float rate = 1.0f;
	public float minHeight = -20.0f;
	public Verb[] triggeredVerbs;

    private Rigidbody rb;
	void Awake () {

		SetAudio();
        //rb = GetComponent<Rigidbody>();
	}

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void FixedUpdate () {
		if(isActive)
		{
            //rb.MovePosition(transform.position - (Vector3.up * rate * Time.deltaTime));
            transform.position -= Vector3.up * rate * Time.deltaTime;

			if(transform.position.y <= minHeight){

                EndVerb();
				Activate(triggeredVerbs);
			}
		}
	}
}