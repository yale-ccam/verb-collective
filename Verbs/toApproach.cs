using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toApproach : Verb
{
    /*
     * Object will move towards a target location at a variable speed. 
     * The speed and location are the main variables for this verb. 
     * The verb will end when the object reaches the target location.
     */

    //______Variable Declarations_____________________
    public float speed = 1.0f;
    public Vector3 targetPos;
    //________________________________________________
    public Verb[] triggeredVerbs;

    void Awake()
    {
        SetAudio();
    }

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            /*Time.deltaTime converts speed from per frame to per time. Makes motion smooth.
            *Object will update based off the target location(targetPos), speed(step)
            *and current position(transform.position).
            ________________________________________________*/
            var step = Time.deltaTime * speed;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
            //_________________________________________________

            if (transform.position == targetPos)
            {

                EndVerb();
                Activate(triggeredVerbs);

            }
        }
    }
}
