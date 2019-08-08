using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verb : MonoBehaviour {

	public AudioClip verbSound;
	public bool loopSound;
	public bool isActive;

	[HideInInspector]
	public AudioSource audioS;

	public void SetAudio () {
		
		if(gameObject.GetComponent<AudioSource>() == null)
		{
			gameObject.AddComponent<AudioSource>();
		}

		audioS = gameObject.GetComponent<AudioSource>();
		audioS.clip = verbSound;
		audioS.loop = loopSound;
		/*if(isActive && !audioS.isPlaying){
			audioS.Play();
		}*/
	}

	public virtual void Conjugate(){
        PlayAudio();
	}

    public void PlayAudio()
    {
        if (!audioS.isPlaying && (verbSound != null))
        {
            audioS.clip = verbSound;
            audioS.loop = loopSound;
            audioS.Play();
        }
    }

    public void CeaseAudio()
    {
        if(audioS.clip == verbSound)
        {
            audioS.Stop();
        }
    }

    public void Activate(Verb[] verbs)
    {
        foreach (Verb item in verbs)
        {
            if (item)
            {
                item.isActive = true;
                item.Conjugate();
            }
        }
    }

    public void Deactivate(Verb[] verbs)
    {
        foreach (Verb item in verbs)
        {
            if (item)
            {
                item.isActive = false;
            }
        }
    }

    public virtual void EndVerb(){
        isActive = false;
        CeaseAudio();
	}
}
