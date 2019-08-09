using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLoad : Verb {

    public string nextScene;

    void Update()
    {
        if (isActive)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
