using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toAttach : Verb
{
    public Verb[] triggeredVerbs;
    public Transform target;

    private void Awake()
    {
        SetAudio();
    }

    private void Update()
    {
        if (isActive)
        {
        	transform.SetParent(target);
            EndVerb();
            Activate(triggeredVerbs);
        }
    }
}
