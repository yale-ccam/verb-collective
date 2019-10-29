/*
* The world can be lonely
* the world can dull
* if you want to make it busy
* add something new
* use this verb to add things
* no need to feel blue
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSpawn : Verb
{


    //Variables required for this verb
    //________________________________

    [Tooltip("Drag the gameobject you want to spawn here")]
    public GameObject theCreated;

    [Tooltip("Select where you want the spawned object to appear")]
    public Vector3 spawnPoint;

    [Tooltip("Turn this on if you want the original object to die after spawning the new object")]
    public bool destroyOnBirth;
    //_________________________________

    public Verb[] triggeredVerbs;



    private void Start()
    {
        SetAudio();
        isActive = false;

        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    private void Update()
    {
        if (isActive)
        {
            //Unique verb content
            //________________________________
            //________________________________

            //Creates a clone of the object provided at the location provided.
            //Quaternion is just setting the rotation of the object
            Instantiate(theCreated, spawnPoint, Quaternion.identity);

            if (destroyOnBirth)
                Destroy(gameObject);

            //Unique verb content
            //________________________________
            //________________________________
            isActive = false;
            CeaseAudio();
            Activate(triggeredVerbs);
        }

    }
}
/*
 * Object will spawn, or be created, at a target location(spawnPoint)
 * User provides the type of object that spawns(theCreated) as well as the target location.
 * User can also decide if the Object the verb is on will destroy at the end of this verb.
 * Generally the spawned object(theCreated) should not be a copy of the object to spawn is attached to
 */
