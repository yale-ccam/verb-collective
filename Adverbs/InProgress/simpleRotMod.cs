using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleRotMod : MonoBehaviour {

	public float floor = 0.0f;

	private Vector3 startForward;
	private AudioSource audio;
	private AudioReverbFilter filter;

	void Awake() {
		startForward = transform.forward; 
		audio = GetComponent<AudioSource>();
		filter = GetComponent<AudioReverbFilter>();
	}

	// Update is called once per frame
	void Update () {

		//creates the link (via the variable audio) to access the game object's base component, in this case the Audio Source


		float yangle = gameObject.transform.forward.y;
		float zangle = gameObject.transform.forward.z;

		float degrees = (180.0f - Vector3.Angle(startForward, transform.forward)) / 180.0f;

		audio.volume = (zangle * -0.5f) + 0.5f;
		audio.pitch = 1f + (yangle * 0.2f);
		//filter.reverbLevel = (zangle * 10) -2000;

	}
}
