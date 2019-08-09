using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toBirth : Verb {

	public GameObject child;
    public Vector3 relativeLocationChild;
	public bool destroyOnBirth;
    public Verb[] triggeredVerbs;

	void Awake () {

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
            Instantiate(child, this.transform.position + relativeLocationChild, Quaternion.identity);

            if (destroyOnBirth)
                Destroy(gameObject);

            isActive = false;
            CeaseAudio();
            Activate(triggeredVerbs);
        }
    }
}
