using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toDie : Verb {

    public Verb[] triggeredVerbs;

    private void Awake()
    {
        SetAudio();
    }

    private void Update()
    {
        if (isActive)
        {
            Activate(triggeredVerbs);
            Destroy(this.gameObject);
        }
    }
}
