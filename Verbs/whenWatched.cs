using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenWatched : Trigger {

    /*
    * Triggers after the object is visible/looked at for a specified duration 
    * User can provide the threshold as well as gazeDuration.
    */

    //______Variable Declarations_____________________
    [Range(10, 90)]
    public float threshold = 10;
    //tell the code to measure from the object's starting point
    public float gazeDuration = 3.0f;
    //________________________________________________
    public Verb[] triggeredVerbs;

    private float timePassed = 0.0f;
    private Transform cameraView;

    private void Awake()
    {
        SetAudio();
        cameraView = Camera.main.transform;
    }


    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
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
        }
    }

    public override void Conjugate()
    {
        timePassed = 0.0f;
    }
}
