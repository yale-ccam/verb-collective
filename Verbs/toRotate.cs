using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRotate : Verb
{
    public Vector3 axis = Vector3.up;
    public float degreesPerSecond = 1.0f;
    public float duration;
    public Verb[] triggeredVerbs;

    private float timeRunning = 0.0f;

    void Awake()
    {
        SetAudio();
    }

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            transform.RotateAround(transform.position, axis, degreesPerSecond * Time.deltaTime);
            timeRunning += Time.deltaTime;

            if (timeRunning > duration)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }
        }
    }

    override public void Conjugate()
    {
        timeRunning = 0.0f;
        PlayAudio();
    }
}
