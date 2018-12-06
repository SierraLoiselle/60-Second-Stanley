using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredAudioScript : MonoBehaviour {
    public AudioClip noise;
    AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(noise, 0.5F);
    }

}
