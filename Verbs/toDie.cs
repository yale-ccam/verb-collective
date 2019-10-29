/*
 * You seem really nice
 * friendly and kind
 * so I'm sad to say it
 * but you're going to die
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toDie : Verb {
    
    public Verb[] triggeredVerbs;

    private void Start()
    {
        SetAudio();
    }

    // Update is called once per frame
    private void Update()
    {
        if (isActive)
        {
            Activate(triggeredVerbs);

            //Unique verb content
            //________________________________
            //________________________________

            Destroy(this.gameObject);

            //________________________________
            //________________________________
        }
    }
}
/*
 * The object subject to this verb will be destroyed, or removed from the scene.
 */
