using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenVisible : Verb {

    /*
    * Triggers if within threshold degrees of the camera center.
    * User can provide a threshold
    */

    //______Variable Declarations_____________________
    public float threshold;
    //tell the code to measure from the object's starting point
    //________________________________________________
    public Verb[] triggeredVerbs;

    private Transform cameraView;
    private bool pastState = false;

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
                if (!pastState)
                {
                    PlayAudio();
                    Activate(triggeredVerbs);
                    pastState = true;
                }
            }
            else
            {
                if (pastState)
                {
                    CeaseAudio();
                    Deactivate(triggeredVerbs);
                    pastState = false;
                }
            }
        }
    }
    
}
