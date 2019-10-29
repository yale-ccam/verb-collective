/*
 * You are playing a game
 * and you defeat the big boss
 * you score the maximum points
 * and never have lost
 *
 * Go to the next level
 * and see something new
 * load a new scene
 * and find something to do
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The package below is required
using UnityEngine.SceneManagement;

public class toLoad : Verb {



    //Variables required for this verb
    //________________________________

    [Tooltip("Carefully type the name of the scene you want to load")]
    public string nextScene;
    
    //________________________________

    void Update()
    {
        if (isActive)
        {
            //Unique verb content
            //________________________________
            //________________________________

            SceneManager.LoadScene(nextScene);

            //________________________________
            //________________________________
        }
    }
}
/*
 * This verb will load a new scene. Scene is provided by user.
 * Be sure to include the scene in the build settings
 */
