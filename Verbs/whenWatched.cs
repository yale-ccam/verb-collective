/*
* Are you looking at me?
* Im looking at you.
* 
* Look long enough
* and you will see what I do.
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenWatched : Trigger {


    //Variables required for this verb
    //________________________________

    [Range(10, 90)]
    [Tooltip("Set how wide the field of view being tested is")]
    public float threshold = 10;
    
    [Tooltip("Set how long someone looks at the object before triggering verbs")]
    public float gazeDuration = 3.0f;

    private float timePassed = 0.0f;
    private Transform cameraView;
    
    //________________________________________________

    public Verb[] triggeredVerbs;



    private void Start()
    {
        SetAudio();

        //Unique verb content
        //________________________________
        //________________________________

        cameraView = Camera.main.transform;

        //________________________________
        //________________________________
    }


    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {

            //Unique verb content
            //________________________________
            //________________________________

            if (Vector3.Angle(cameraView.forward, (transform.position - cameraView.position)) < threshold)
            {
                timePassed += Time.deltaTime;
            }
            else
            {
                timePassed = 0.0f;
            }

            if(timePassed >= gazeDuration)
            {
                isActive = false;
                Activate(triggeredVerbs);
            }

            //________________________________
            //________________________________
        }
    }

    //Unique verb content
    //________________________________
    //________________________________
    public override void Conjugate()
    {
        timePassed = 0.0f;
    }
    //________________________________
    //________________________________
}

/*
* Triggers after the object is visible/looked at for a specified duration 
* User can provide the threshold as well as gazeDuration.
*/
