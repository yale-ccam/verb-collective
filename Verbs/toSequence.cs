/*
 * Sometimes you want things to happen
 * one at a time, first this
 * then that, then the other
 * then again, over and over
 * 
 * You can make it random
 * or use it in a line
 * you can have it grow
 * then shrink the next time
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSequence : Verb

{

    //Variables required for this verb
    //________________________________
    
    [Tooltip("Turn this on to determine if sequence should be random, otherwise it will run the scripts in order")]
    public bool randomize;

    //SerializeField is just making this private variable, below, visible in the Unity Editor.

    [SerializeField]
    private int currentNumber = 0;

    [SerializeField]
    private int numberOfSteps;
    //_________________________________

    public Verb[] triggeredVerbs;



    void Start()

    {

        SetAudio();

        if (isActive)
      
            PlayAudio();

        //Unique verb content
        //________________________________
        //________________________________

        //checks the verb toSequence() to check how many trigger verbs are currently in the list.
        numberOfSteps = triggeredVerbs.Length;
        
        //if boolean is true, the starting point for the sequence will be set to random between 0
        //and the total number of triggeredVerbs

        if (randomize)

        {
            currentNumber = Random.Range(0, numberOfSteps);
        }

        //________________________________
        //________________________________

    }

    // FixedUpdate is called once per frame

    void FixedUpdate()
    {
        //Unique verb content
        //________________________________
        //________________________________
        if (isActive && numberOfSteps != 0)

        {

            EndVerb();

            Activate(triggeredVerbs[currentNumber]);



            if (randomize)
            {

                int next = Random.Range(0, numberOfSteps);

                // the ? and : in this statement are part of a ternary operator

                // Condition? If true : If false

                currentNumber = (next == currentNumber) ? ((next + 1) % numberOfSteps) : next;

            }

            else
            {

                currentNumber = (currentNumber + 1) % numberOfSteps;

            }

        }
        //________________________________
        //________________________________

    }

}

/*
 * This verb is a sequencer that lets you choose an array of verbs to either trigger in order
 * or else trigger at random, without repeating.  
 */
