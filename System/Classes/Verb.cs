using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verb : MonoBehaviour {

    [Tooltip("Drag an audio source here to play when triggered")]
	public AudioClip verbSound;
    [Tooltip("Turn this on to have the audio loop")]
    public bool loopSound;
    [Tooltip("Turn this on to have the verb be active on start")]
    public bool isActive;

	[HideInInspector]
	public AudioSource audioS;

	public void SetAudio () {
        

        if (gameObject.GetComponent<AudioSource>() == null)
		{
            gameObject.AddComponent<AudioSource>();

        }

        audioS = gameObject.GetComponent<AudioSource>();

        if (verbSound != null)
        {
            audioS.clip = verbSound;
            audioS.loop = loopSound;
        }
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
            Debug.Log("here");
        }
    }

    public void CeaseAudio()
    {
        if(audioS.clip == verbSound)
        {
            Debug.Log("here2");
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

    public void Activate(Verb verbs)
    {
                verbs.isActive = true;
                verbs.Conjugate();
            
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
