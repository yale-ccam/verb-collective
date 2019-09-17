using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toStop : Verb {
    /*
     * This verb will stop all actions on the object. It will stop
     * all active triggerverbs
     */

    public Verb[] triggeredVerbs;

    // Update is called once per frame
    void Update () {
        if (isActive)
        {
            isActive = false;
            Deactivate(triggeredVerbs);
        }
	}
}
