using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toReturn : Verb {

    public float returnRate = 5.0f;
    public Verb[] triggeredVerbs;

    private float startTime;
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    void Awake()
    {
        SetAudio();

        startingPosition = this.transform.position;
        startingRotation = this.transform.rotation;
        this.isActive = false;
    }

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update () {
		if(isActive)
		{
            float step = returnRate * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, startingPosition, step);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, startingRotation, 30.0f * step);

            if (this.transform.position == startingPosition && this.transform.rotation == startingRotation)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }
        }
	}
}
