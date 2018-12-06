using System.Collections;
using System.Collections.Generic;
//Attach this script to an empty GameObject. Create 2 more GameObjects and attach a Collider component on each. Choose these as the "My Object" and "New Object" in the Inspector.
//This script allows you to move your main GameObject left to right. If it intersects with the other, it outputs the message to the Console.

using UnityEngine;

public class BoundsIntersectExample : MonoBehaviour
{
    public GameObject m_MyObject, m_NewObject;
    Collider m_Collider, m_Collider2;
    public AudioClip music;
    AudioSource audioSource;

    void Start()
    {
        //Check that the first GameObject exists in the Inspector and fetch the Collider
        if (m_MyObject != null)
            m_Collider = m_MyObject.GetComponent<Collider>();

        //Check that the second GameObject exists in the Inspector and fetch the Collider
        if (m_NewObject != null)
            m_Collider2 = m_NewObject.GetComponent<Collider>();
        audioSource = m_NewObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        //If the first GameObject's Bounds enters the second GameObject's Bounds, output the message
        if (m_Collider.bounds.Intersects(m_Collider2.bounds))
        {
            audioSource.PlayOneShot(music, 0.7F);
        }
    }
}