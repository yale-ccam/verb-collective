using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toEnable : Verb
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
            EndVerb();
            target.SetActive(true);
        }
    }
}
