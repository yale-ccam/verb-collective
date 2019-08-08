using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class toAnimate : Verb
{

    public string animationName;
    public Verb[] triggeredVerbs;

    private float timePassed;
    private Animator anim;

    void Awake()
    {
        SetAudio();
        Conjugate();
    }

    private void Start()
    {
        anim = GetComponent<Animator>();
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName(animationName))
            {
                anim.Play(animationName);
            }

            timePassed += Time.deltaTime;

            //need to get duration of current animation clip
            if (timePassed >= 3.0f)
            {
                isActive = false;
                CeaseAudio();
                Activate(triggeredVerbs);
            }
        }
    }

    override public void Conjugate()
    {
        timePassed = 0.0f;
        base.Conjugate();
    }
}