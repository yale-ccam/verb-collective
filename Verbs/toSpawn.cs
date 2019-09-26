using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSpawn : Verb
{
    /*
     * Object will spawn, or be created, at a target location(spawnPoint)
     * User provides the type of object that spawns(theCreated) as well as the target location.
     * User can also decide if the Object the verb is on will destroy at the end of this verb.
     * Generally the spawned object(theCreated) should not be a copy of the object to spawn is attached to
     */

    //______Variable Declarations_____________________
    public GameObject theCreated;
    public Vector3 spawnPoint;
    //a variable that works like a true/false statement to determine destroying Object.
    public bool destroyOnBirth;
    //________________________________________________
    public Verb[] triggeredVerbs;

    void Awake()
    {

        SetAudio();
        isActive = false;
    }

    private void Start()
    {
        if (isActive)
            PlayAudio();
    }

    // Update is called once per frame
    private void Update()
    {
        if (isActive)
        {
            //Creates a clone of the object provided at the location provided.
            //Quaternion is just setting the rotation of the object
            Instantiate(theCreated, spawnPoint, Quaternion.identity);

            if (destroyOnBirth)
                Destroy(gameObject);

            isActive = false;
            CeaseAudio();
            Activate(triggeredVerbs);
        }
    }
}
