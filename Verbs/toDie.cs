using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toDie : Verb {
    
    /*
     * The object subject to this verb will be destroyed, or removed from the scene.
     */

    public Verb[] triggeredVerbs;

    private void Awake()
    {
        SetAudio();
    }

    // Update is called once per frame
    private void Update()
    {
        if (isActive)
        {
            Activate(triggeredVerbs);
            //This command will remove the object from the scene after triggers are activated
            Destroy(this.gameObject);
        }
    }
}
