using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toFace : Verb {

	public float speed = 1.0f;
	public Transform target;
    public bool constant;
    public Verb[] triggeredVerbs;

	void Awake () {

		SetAudio();
	}

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    void Update () {
		if(isActive)
		{
			var step = Time.deltaTime * speed;

			Vector3 targetRot = Vector3.Normalize(target.position - this.transform.position);
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetRot, step, 0.0f);
			transform.rotation = Quaternion.LookRotation(newDir);

            if(!constant && Vector3.Dot(transform.forward, targetRot) >= 1.0f)
            {
                EndVerb();
                Activate(triggeredVerbs);
            }
		}
	}
}
