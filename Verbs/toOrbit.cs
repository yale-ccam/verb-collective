using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toOrbit : Verb {

	public Transform target;
	public Vector3 axis = Vector3.up;
	public float speed = 10.0f;
    public float duration;
    public Verb[] triggeredVerbs;

    private float timeRunning;

	void Awake()
	{
		SetAudio();
        timeRunning = 0.0f;
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
			transform.RotateAround(target.position, axis, speed * Time.deltaTime);
            timeRunning += Time.deltaTime;

            if (timeRunning > duration)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }
		}
	}
}
