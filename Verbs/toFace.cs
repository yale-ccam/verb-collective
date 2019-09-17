using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toFace : Verb {

    /*
     * The object will rotate to face a target object.
     * The speed at which the object rotates is set by the user.
     * The user can also choose if this happens once or continuously.
     */

    //______Variable Declarations_____________________
    public float speed = 1.0f;
	public Transform target;
    //a variable that works like a true/false statement to determine constant state. 
    public bool constant;
    //________________________________________________
    public Verb[] triggeredVerbs;

	void Awake () {

		SetAudio();
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
            //______________________________________________________
            //Time.deltaTime is used to make the rotation of the object smooth and bases 
            //that movement off of time and not per frame.
			var step = Time.deltaTime * speed;
            //Finds the normalized difference between object and target object position.
			Vector3 targetRot = Vector3.Normalize(target.position - this.transform.position);
            //Sets the necessary rotation speed to keep focus on target object
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetRot, step, 0.0f);
            //Keeps the object from rotating beyond the scope of the target object
			transform.rotation = Quaternion.LookRotation(newDir);
            //_______________________________________________________

            if(!constant && Vector3.Dot(transform.forward, targetRot) >= 1.0f)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }
		}
	}
}
