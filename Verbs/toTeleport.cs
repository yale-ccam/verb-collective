using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toTeleport : Verb {

    /* 
     * Object will instantly move its position to a target position. The user can decided
     * if this movement will be two-way and teleport back to a second position.
     * User provides target position(targetPos) and a second position(pastPos)
     */

    //______Variable Declarations_____________________
    public Vector3 targetPos;
	public Vector3 pastPos;
    //a variable that works like a true/false statement to determine two-way teleporting. 
    //________________________________________________
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

    // Update is called once per frame
    void Update () {
		if(isActive)
		{
            //Two conditions that check if the boolean above way set to true/false
            if (twoWayTeleporting)
            {
                //sets pastPost to the current position of the Object
                pastPos = this.transform.position;
                //sets the current position of Object to target position, ie. Teleports
                this.transform.position = targetPos;
                //switches location again before it will repeat at the start of this condition.
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
