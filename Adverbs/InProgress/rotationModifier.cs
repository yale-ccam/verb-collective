using UnityEngine;
using System.Collections;

public class rotationModifier : MonoBehaviour {

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		//creates the link (via the variable audio) to access the game object's base component, in this case the Audio Source
		AudioSource audio = GetComponent<AudioSource>();
		AudioReverbFilter filter = GetComponent<AudioReverbFilter>();


		float xangle = gameObject.transform.localEulerAngles.x;
		float yangle = gameObject.transform.localEulerAngles.y;
		float zangle = gameObject.transform.localEulerAngles.z;

		float height = gameObject.transform.position.y;

		float r = ((xangle / 360)*-1) + 1;
		float g = ((yangle / 360)*-1) + 1;
		float b = ((zangle / 360)*-1) + 1;



		audio.volume = height - 1;
		audio.pitch = (yangle -180) / 60;
		filter.reverbLevel = (zangle * 10) -2000;


		//if (zangle > 1) {
		//}
		//	transform.localScale = new Vector3(zangle/360, 1, 1);
			

		gameObject.GetComponent<Renderer> ().material.color = new Color(r,g,b);



		//Debug.Log ("xangle = " + xangle + " yangle = " + " zangle = " + zangle);

	




	}
}
