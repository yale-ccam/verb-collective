using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toWait : Verb {

	public float duration = 3.0f;
	public Verb[] triggeredVerbs;

	private float timePassed;

	void Awake () {
		SetAudio();
		Conjugate();
	}

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    void Update () {
		if(isActive)
		{
			timePassed += Time.deltaTime;

			if(timePassed >= duration)
			{
				isActive = false;
                CeaseAudio();
                Activate(triggeredVerbs);
			}
		}
	}

	override public void Conjugate () {
		timePassed = 0.0f;
        base.Conjugate();
	}
}
