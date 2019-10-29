/*
 * I am nothing
 * you are nothing
 * we know nothing
 * nothing can be known
 * 
 * However...
 * This is a template 
 * for making your own verb
 * so just copy and paste
 * into a script
 * and call it toSomething
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * When you create a new verb 
 * it is important that the name 
 * of your script replaces 'toExample' below. 
 */
public class toExample : Verb
{

    //Variables required for this verb
    //________________________________

    /*
     * Anytime you make a verb
     * if it requires specific variables,
     * whether private or public, to work
     * place them here.
     */

    //public String ExampleVariable;


    //______________________________


    // The line below is necessary to call other Verbs
    public Verb[] triggeredVerbs;


    /*
     * Your Verb needs this to function. 
     * It initializes the script 
     * and sets the audio functions
     * Do not remove.
     */
    private void Start()
    {
        //Helper function to set up the Audio Source tied to the verb
        SetAudio();

        if (isActive)
            PlayAudio();
    }

    /*
     * Your Verb will update every frame 
     * with this function. 
     * This is very important 
     * and should not be removed.
     * 
     * Note: If you are using a rigidbody
     * and moving things around with force
     * you might need to use FixedUpdate
     */

    void Update()
    {
        // If your verb is active the scripts below will run
        if (isActive)
        {
            /*
             * Verbs can be really simple
             * as small as a single line of code
             * using verbs means you only 
             * need to write a tiny snippet
             * and you can paste it in here
             */

            //The Action of the Verb, what does it do?

            //Unique verb content
            //________________________________
            //________________________________

            Debug.Log("I am");

            //________________________________
            //________________________________

            //Termination condition, when does it stop?

            /* The following if statement 
             * is an example and should be replaced 
             * to match your desired action.
             * I added a second condition,
             * using &&, which basically means 'and'
             * 
             * - you don't need multiple conditions
             * - but I like you to know your options.
             * 
             * if all of the conditions are met
             * then the verb will trigger the other verbs
             * and turn off
             */

            // if (variable1 == variable2 && otherCondition == conditionMet)
            {

                /*
                 * The two functions below are required.
                 * They signal the end of the Verb,
                 * and they activate the verbs 
                 * added to the Triggered Verbs array
                 */

                EndVerb();
                Activate(triggeredVerbs);
            }
        }
    }
}
/*
 * This is a template script
 * that teaches you how to write new verbs
 * if you are using it, it only takes a minute
 * to make a new verb.
 * I recommend copying and pasting the important bits
 * into a new script because as much as I like my comments...
 * well...
 * this one has got a lot of them...
 */
