/* 
 * This verb might be
 * the solution
 * to the Santa paradox
 * 
 * There are no reindeers, 
 * only this script
 * 
 * And Santa uses it
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toTeleport : Verb {


    //Variables required for this verb
    //________________________________

    [Tooltip("Choose the location that you want to teleport to")]
    public Vector3 targetPos;

    [Tooltip("If you want to return to your initial location afterwards, select this option")]
    public bool twoWayTeleporting;

    private Vector3 pastPos;

    //________________________________

    public Verb[] triggeredVerbs;



    private void Start()
    {
        SetAudio();
        if (isActive)
            PlayAudio();
    }


    void Update () {
		if(isActive)
		{
            //Unique verb content
            //________________________________
            //________________________________

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

            //________________________________
            //________________________________

            isActive = false;
            CeaseAudio();
            Activate(triggeredVerbs);
		}
	}
	
	
}
/* 
 * Object will instantly move its position to a target position. The user can decided
 * if this movement will be two-way and teleport back to a second position.
 * User provides target position(targetPos) and a second position(pastPos)
 */
