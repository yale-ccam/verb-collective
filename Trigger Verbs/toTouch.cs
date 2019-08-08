using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toTouch : Verb {

    public bool deactivateOnTouch;
    public Verb[] triggeredVerbs;

    private void Awake()
    {
        SetAudio();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isActive){
            PlayAudio();
            Activate(triggeredVerbs);

            if(deactivateOnTouch)
                isActive = false;
          }
    }
}
