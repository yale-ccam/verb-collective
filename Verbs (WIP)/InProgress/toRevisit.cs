using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRevisit : Verb
{
    public float returnRate = 5.0f;
    public Verb[] triggeredVerbs;

    private float startTime;
    private Vector3 startingPosition;
    private Quaternion startingRotation;
    private Rigidbody rb;

    void Awake()
    {
        SetAudio();

        startingPosition = this.transform.position;
        startingRotation = this.transform.rotation;
        this.isActive = false;

        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
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
			rb.MovePosition(transform.position + Vector3.Normalize(startingPosition - transform.position) * returnRate * Time.fixedDeltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, startingRotation, 30.0f * returnRate * Time.fixedDeltaTime);

            if (this.transform.position == startingPosition && this.transform.rotation == startingRotation)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }
        }
	}
}
