using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(AudioHighPassFilter))]
[RequireComponent(typeof(AudioLowPassFilter))]


public class audioPositionAlters : MonoBehaviour {



	private float positionx;
	private float positiony;
	private float positionz;
    private float scalez;
    public float highmod = 700f;
    public float highbase = 100f;
    public float lowmod = 5000f;
    public float lowbase = 0f;

	

	// Update is called once per frame
	void Update () {

        //creates the link (via the variable audio) to access the game object's base component, in this case the Audio Source
        AudioSource audio = GetComponent<AudioSource>();
        AudioHighPassFilter highpass = GetComponent<AudioHighPassFilter>();
        AudioLowPassFilter lowpass = GetComponent<AudioLowPassFilter>();

        positionx = GetComponent<Transform>().position.x;
        positiony = GetComponent<Transform>().position.y;
        positionz = GetComponent<Transform>().position.z;
        scalez = GetComponent<Transform>().lossyScale.z;

        audio.pitch = scalez * 5;

        if (-2f < positionx && positionx <= 2f)
        {
            float v = ((positionx + 2f) * lowmod);
            lowpass.cutoffFrequency = lowbase + v;
            
        }

        if (-2f < positionz && positionz <= 2f)
        {
            float x = ((positionz + 2f) * highmod);
            highpass.cutoffFrequency = highbase + x;


        }

        if (0f < positiony && positiony <= 2f)
        {
            audio.volume = positiony - .1f;


        }










	}
}
