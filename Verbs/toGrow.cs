using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toGrow : Verb {

	public float growMultiplier = 2.0f;
	public float duration = 3.0f;
    public Verb[] triggeredVerbs;

	private float timePassed;
	private Vector3 StartScale;
	private Vector3 FinalScale;

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
			transform.localScale = Vector3.Lerp(StartScale, FinalScale, timePassed);
			timePassed += Time.deltaTime / duration;

			if(timePassed >= 1.0f)
			{
                EndVerb();
                Activate(triggeredVerbs);
			}
		}
	}

	override public void Conjugate () {
		StartScale = this.transform.localScale;
		FinalScale = StartScale * growMultiplier;
		timePassed = 0.0f;
        PlayAudio();
	}
}
