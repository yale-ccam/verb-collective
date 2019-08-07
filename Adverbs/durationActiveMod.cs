using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class durationActiveMod : MonoBehaviour {

    public Verb watchedVerb;
    public float rate = 0.05f;
    [SerializeField]
    private float timeActive = 0.0f;
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if (watchedVerb.isActive)
        {
            timeActive += Time.deltaTime * rate;
            source.volume = Mathf.Clamp(timeActive, 0.0f, 1.0f);
        }
	}
}
