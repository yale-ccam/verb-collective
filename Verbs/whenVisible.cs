/*
* Peek a boo
* I see you
* 
* If can you see me
* you will see what I do
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenVisible : Verb {

    //Variables required for this verb
    //________________________________

    [Range(10, 90)]
    [Tooltip("This number determines the angle of view for determining whether the object is visible or not")]
    public float threshold;

    private Transform cameraView;
    private bool pastState = false;

    //______________________________

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

            //________________________________
            //________________________________
        }
    }

}
/*
* Triggers when the object is looked at
* User can provide a threshold for how central to the camera
* an object needs to be to be considered visible
*/
