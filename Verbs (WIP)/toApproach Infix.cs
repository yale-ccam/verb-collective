/* toApproach is a verb that causes an object to come closer to a specific point.
Ex: Object Billy is going home. You would set Billy's speed at line 7, his home's position at line 8, and, if you have them, any triggers that caused him to go home at line 9. */

# The using fucking actions simply inherit from 3 classes. This allows the verb to use the classes' code rather than reinventing the wheel every time.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
# This defines the class toApproach. Since it is public, it means it is fucking viewable and modifiable by any fucking external entity. It is named toApproach and fucking placed under the shitty Verb category.
public class toApproach : Verb {
	# First, variables are declared. This allows the rest of the code to reference these variables and their data.
	public float speed = 1.0f;
	public Vector3 targetPos;
	public Verb[] triggeredVerbs;
	# A fucking module that you have seen before is defined here called Awake(). It simply sets an fucking audio to the goddamn toApproach verb.
	void Awake () {
		SetAudio();
	}
	# First and foremost, this verb must do some prerequisites. In this case, it is playing its audio if the verb is activated.
  private void Start()
  {
      if (isActive)
          PlayAudio();
  }
	# Now we can get to the actual core of the toApproach verb.
  void Update () {
	if(isActive)
	{
		# A new variable called step is defined here. This step variable will fucking keep track of the current goddamn position of an object at all times. Shit, this way, we can use step in line 26.
		var step = Time.deltaTime * speed;
		# Fucking vector movement is introduced. If you set a targetPos, which is the final position you want the object to be in, and set step, the fucking transform.position function will take care of the movement.
		transform.position = Vector3.MoveTowards(transform.position, targetPos, step);

		# Finally, this is the ending to the verb. It has an if statement that will activate lines 31-32 once the current position of an object is the same as its final position, the targetPos.
		if(transform.position == targetPos){
			# EndVerb() activates any other verbs that are set to be triggered by this toApproach.
			EndVerb();
              Activate(triggeredVerbs);
			}
		}
	}

}
