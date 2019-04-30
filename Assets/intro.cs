using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour {

    // Use this for initialization
    AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("GameObject").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            SceneManager.LoadScene("Locked Room w water and audio");
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Locked Room w water and audio");
        }
    }
}
