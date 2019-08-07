using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complexRotMod : MonoBehaviour {

	public float floor = 0.0f;

	private Vector3 startForward;
	private AudioSource audio;
	private AudioEchoFilter echo;
	//private AudioDistortionFilter distortion;
	//private AudioHighPassFilter high;
	//private AudioLowPassFilter low;
	//private AudioChorusFilter chorus;
	private AudioReverbFilter reverb;

	void Awake() {
		startForward = transform.forward; 
		audio = GetComponent<AudioSource>();
		echo = GetComponent<AudioEchoFilter>();
		//distortion = GetComponent<AudioDistortionFilter>();
		//high = GetComponent<AudioHighPassFilter>();
		//low = GetComponent<AudioLowPassFilter>();
		//chorus = GetComponent<AudioChorusFilter>();
		reverb = GetComponent<AudioReverbFilter>();
	}

	// Update is called once per frame
	void Update () {

		//creates the link (via the variable audio) to access the game object's base component, in this case the Audio Source


		float yangle = gameObject.transform.forward.y;
		float zangle = gameObject.transform.forward.z;
		float xangle = gameObject.transform.forward.x;

		float degrees = (180.0f - Vector3.Angle(startForward, transform.forward)) / 180.0f;

		audio.volume = (zangle * -0.5f) + 0.5f;
		echo.delay = (yangle * 500.0f) + 500.0f;
		reverb.reverbLevel = (xangle * 10) -2000;
		//distortion.distortionLevel = (zangle + 1.0f) * 0.1f;

		//high.highpassResonanceQ = ...
		//low.lowpassResonanceQ = ...
		//chorus.depth = ...
		//reverb.decayTime = ...
		//

	}
}
