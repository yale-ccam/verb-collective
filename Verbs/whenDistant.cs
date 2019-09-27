using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenDistant : Verb {

    /*
	* Triggers if the object is over distance from point
	* point can either be set in inspector or will default to the starting point
    * User can provide the treshold as well as the target object. User can
    * provide the option of this trigger occuring due to proximity and/or only triggering once.
    */

    //______Variable Declarations_____________________
    public Transform target;
	public float threshold;
	public bool triggerWhenNear;
    public bool triggerOnlyOnce;
	//tell the code to measure from the object's starting point
    //_________________________________________________
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
            // ^ is an operand for XOR, so if this exceeds the threshold or the triggerWhenNear value
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