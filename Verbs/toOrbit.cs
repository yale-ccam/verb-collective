using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toOrbit : Verb {

    /*
     * Object will orbit around a target object at a variable speed and duration of time
     * User will set the speed and duration, as well as select the target object
     * User can select the axis as well, but default of orbtining on the y-axis has been provided.
     */

    //______Variable Declarations_____________________
    public Transform target;
	public Vector3 axis = Vector3.up;
	public float speed = 10.0f;
    public float duration;
    //________________________________________________
    public Verb[] triggeredVerbs;

    private float timeRunning;

	void Awake()
	{
		SetAudio();
        //sets value of timeRunning before any transformation occur
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
            //Each time Update() runs the object's position will update based on its current position,
            //the axis provided, and the speed. Multiplying by Time.deltaTime will provide a smooth transition.
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
