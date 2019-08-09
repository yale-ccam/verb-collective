using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSpawn : Verb
{

    public GameObject theCreated;
    public Vector3 spawnPoint;
    public bool destroyOnBirth;
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

    private void Update()
    {
        if (isActive)
        {
            Instantiate(theCreated, spawnPoint, Quaternion.identity);

            if (destroyOnBirth)
                Destroy(gameObject);

            isActive = false;
            CeaseAudio();
            Activate(triggeredVerbs);
        }
    }
}
