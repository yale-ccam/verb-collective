using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioEchoFilter))]
public class cameraDistanceModifier : MonoBehaviour {

    private Transform cameraView;
    private AudioSource source;
    //private AudioEchoFilter filter;

    private void Awake()
    {
        cameraView = Camera.main.transform;
        //filter = GetComponent<AudioEchoFilter>();
        source = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        //filter.delay = Mathf.Clamp( Vector3.Distance(cameraView.position, transform.position) * 20.0f, 100.0f, 2000.0f);
        source.volume = Mathf.Clamp(Vector3.Distance(cameraView.position, transform.position) * 0.05f, 0.0f, 1.0f);
    }
}
