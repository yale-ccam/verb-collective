/*
 * Take an object
 * Make it go
 * Take another object
 * Make it show
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSwitch : Verb
{


    //Variables required for this verb
    //________________________________

    [Tooltip("Any gameobjects that you drag into this field will be disactivated")]
    public GameObject[] remove;

    [Tooltip("Any gameobjects that you drag into this field will be activated")]
    public GameObject[] replace;

    //________________________________

   
    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }


    private void Update()
    {

        if (isActive)
        {
            //this will end this condition once it passes through a single time
            isActive = false;
            Activate(triggeredVerbs);

            //Unique verb content
            //________________________________
            //________________________________

            foreach (GameObject item in remove)
            {

                item.SetActive(false);
            }

            foreach (GameObject item in replace)
            {
                item.SetActive(true);
            }

            //________________________________
            //________________________________
        }
    }
}
/*
 * This verb switches out objects 
 * by turning an array of objects off 
 * and then turning a second array of objects on
 */
