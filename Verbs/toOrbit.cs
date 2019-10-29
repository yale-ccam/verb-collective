/*
 * Think of the sun,
 * then the planets 
 * and moons
 * 
 * They all circle around
 * one thing or another
 * whether galaxies afar
 * or even each other
 * 
 * Pick something to circle
 * and use this verb
 * - you'll feel super celestial
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toOrbit : Verb {

    //Variables required for this verb
    //________________________________

    [Tooltip("Drag the gameobject you want to orbit here")]
    public Transform target;

    [Tooltip("Choose a number between 0 and 1 for each axis, with a higher number being used to select the axis for rotation")]
    public Vector3 axis = Vector3.up;

    [Tooltip("Choose the speed at which to orbit the target object")]
    public float speed = 10.0f;

    [Tooltip("Choose how long you want it to orbit")]
    public float duration;
    
    private float timeRunning;

    //_________________________________

    public Verb[] triggeredVerbs;


    private void Start()
    {
        SetAudio();
        //sets value of timeRunning before any transformation occur
        timeRunning = 0.0f;

        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update () {
		if(isActive)
		{

            //Unique verb content
            //________________________________
            //________________________________

            //Each time Update() runs the object's position will update based on its current position,
            //the axis provided, and the speed. Multiplying by Time.deltaTime will provide a smooth transition.
            transform.RotateAround(target.position, axis, speed * Time.deltaTime);
            timeRunning += Time.deltaTime;

            if (timeRunning > duration)
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
 * Object will orbit around a target object at a variable speed and duration of time
 * User will set the speed and duration, as well as select the target object
 * User can select the axis as well, but default of orbtining on the y-axis has been provided.
 */
