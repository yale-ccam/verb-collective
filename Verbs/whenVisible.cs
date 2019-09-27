using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenVisible : Verb {

    /*
    * Triggers when the object is looked at
    * User can provide a threshold for how central to the camera
    * an object needs to be to be considered visible
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
