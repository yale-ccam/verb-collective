using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenDistant : Verb {

	//triggers if the object is over distance from point
	//point can either be set in inspector or will default to the starting point
	public Transform target;
	public float threshold;
	public bool triggerWhenNear;
    public bool triggerOnlyOnce;
	//tell the code to measure from the object's starting point
	public Verb[] triggeredVerbs;
	private bool pastState = false;

    private void Awake()
    {
        SetAudio();
    }

    // Update is called once per frame
    void Update () {

        if (isActive)
        {
            if (Vector3.Distance(transform.position, target.position) > threshold ^ triggerWhenNear)
            {
                if (!pastState)
                {
                    PlayAudio();
                    Activate(triggeredVerbs);

                    if (triggerOnlyOnce)
                    {
                        Destroy(this);
                    }
                    pastState = true;
                }
            }
            else
            {
                if (pastState)
                {
                    CeaseAudio();
                    Deactivate(triggeredVerbs);
                    pastState = false;
                }
            }
        }
	}
}