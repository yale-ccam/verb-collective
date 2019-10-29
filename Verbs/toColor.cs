/*
* Roses are Red 
* Violets are Blue
* The color this turns
* is up to you
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toColor : Verb
{
    //Variables required for this verb
    //________________________________

    [Range(0, 1)]
    [Tooltip("Use this to set a value for the amount of red between 1 and 0")]
    public float red = 1f;

    [Range(0, 1)]
    [Tooltip("Use this to set a value for the amount of green between 1 and 0")]
    public float green = 0f;

    [Range(0, 1)]
    [Tooltip("Use this to set a value for the amount of blue between 1 and 0")]
    public float blue = 0f;

    [Range(0, 1)]
    [Tooltip("Use this to set a value for the alpha, or transparency, between 1 and 0")]
    public float alpha = 1f;

    //________________________________

    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }


    void Update()
    {
        if (isActive)
        {

            //Unique verb content
            //________________________________

            Color newColor = new Color(red, green, blue, alpha);
            GetComponent<Renderer>().material.color = newColor;  

            //________________________________


            isActive = false;
            Activate(triggeredVerbs);
            
        }
    }
}

/*
 * This verb changes the color of the object it is attached to 
 */
