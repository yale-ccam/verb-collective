using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toStop : Verb {

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
