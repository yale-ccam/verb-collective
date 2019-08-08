using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toDisable : Verb
{
    public Verb[] triggeredVerbs;
    public GameObject target;

    private void Awake()
    {
        SetAudio();
    }

    private void Update()
    {
        if (isActive)
        {
            isActive = false;
            Activate(triggeredVerbs);
            target.SetActive(false);
        }
    }
}

