/*
 * Wherever you go
 * I will find you
 * Everything you do
 * I can see
 * Its not that I am creepy
 * but that something triggered me
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toFace : Verb {


    //Variables required for this verb
    //________________________________

    [Tooltip("Choose how quickly you want the object to turn")]
    public float speed = 1.0f;
    [Tooltip("Drag the gameobject you want to turn towards here")]
    public Transform target;
    [Tooltip("Turn this on if you want to effect to be perpetual")]
    public bool constant;

    //________________________________

    public Verb[] triggeredVerbs;


    private void Start()
    {
        SetAudio();

        if (isActive)
            PlayAudio();
    }


    void Update () {

		if(isActive)
		{
            //Unique verb content
            //________________________________
            //________________________________

            var step = Time.deltaTime * speed;
            
            //Finds the normalized difference between object and target object position.
			Vector3 targetRot = Vector3.Normalize(target.position - this.transform.position);
            
            //Sets the necessary rotation speed to keep focus on target object
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetRot, step, 0.0f);
            
            //Keeps the object from rotating beyond the scope of the target object
			transform.rotation = Quaternion.LookRotation(newDir);


            if (!constant && Vector3.Dot(transform.forward, targetRot) >= 1.0f)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }

            //________________________________
            //________________________________
		}
	}
}
/*
 * The object will rotate to face a target object.
 * The speed at which the object rotates is set by the user.
 * The user can also choose if this happens once or continuously.
 */
