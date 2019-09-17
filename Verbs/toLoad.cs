using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLoad : Verb {

    /*
     * This verb will load a new scene. Scene is provided by user.
     */

    //______Variable Declarations_____________________
    public string nextScene;
    //________________________________________________

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
