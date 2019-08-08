using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toTeleport : Verb {

	public Vector3 targetPos;
	public Vector3 pastPos;
    public bool twoWayTeleporting;

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
            if (twoWayTeleporting)
            {
                pastPos = this.transform.position;
                this.transform.position = targetPos;
                targetPos = pastPos;
            }
            else
            {
                this.transform.position = targetPos;
            }

            isActive = false;
            CeaseAudio();
            Activate(triggeredVerbs);
		}
	}
	
	
}
