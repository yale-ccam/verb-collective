/*
 * If you want to move
 * towards some distant point
 * this works to send things
 * wherever you want
 */
     
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toFollow : Verb
{


    //Variables required for this verb
    //________________________________

    [Tooltip("This determines the speed the object will move")]
    public float speed = 1.0f;

    [Tooltip("Drag the object you want to move towards here")]
    public Transform target;

    [Tooltip("How long do you want the object to move toward the selected gameobject?")]
    public float duration;

    [Tooltip("Turn this on if you want the verb to end whenever it reaches the target object")]
    public bool StopOnArrival;

    private float timeRunning;

    //________________________________
    public Verb[] triggeredVerbs;



    private void Start()
    {
        SetAudio();
        //Required initalization for the verb to work
        timeRunning = 0.0f;
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {

            //Unique verb content
            //________________________________
            //________________________________

            /*Time.deltaTime converts speed from per frame to per time. Makes motion smooth.
            *Object will update based off the target location(targetPos), speed(step)
            *and current position(transform.position).
            */
            var step = Time.deltaTime * speed;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            timeRunning += Time.deltaTime;

            if (timeRunning > duration)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }

            else if (StopOnArrival == true && transform.position == target.position)
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
 * Object will move towards a target object at a variable speed. 
 * The speed and the target object are the main variables for this verb. 
 * The verb will end when the object reaches the target location or the timer runs out.
 */
