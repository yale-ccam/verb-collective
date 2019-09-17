using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenHeld : Verb {

   /*
   * Triggers when trigger object is entered, like pressing a button, onto another object
   */

    public Verb[] triggeredVerbs;

    private void Awake()
    {
        SetAudio();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isActive)
        {
            PlayAudio();
            Activate(triggeredVerbs);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isActive)
        {
            CeaseAudio();
            Deactivate(triggeredVerbs);
        }
    }
}
