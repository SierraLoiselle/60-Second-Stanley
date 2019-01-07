using System.Collections;
using System.Collections.Generic;
//Attach this script to an empty GameObject. Create 2 more GameObjects and attach a Collider component on each. Choose these as the "My Object" and "New Object" in the Inspector.
//This script allows you to move your main GameObject left to right. If it intersects with the other, it outputs the message to the Console.

using UnityEngine;

public class BoundsIntersectExample : MonoBehaviour
{
    public GameObject PersonObject, WaterObject, WaterfallObject;
    Collider PersonCollider, WaterCollider;
    public AudioClip WaterfallSound, WaterSound;
    AudioSource WaterFallSource, WaterSource;
    bool PlayerInWater;

    void Start()
    {
        //check if person object exists and fetch collider
        if (PersonObject != null)
        {
         PersonCollider = PersonObject.GetComponent<Collider>();
        }
            

        //check if water object exists and fetch collider and audio source
        if (WaterObject != null)
        {
            WaterCollider = WaterObject.GetComponent<Collider>();
            WaterSource = WaterObject.GetComponent<AudioSource>();
        }
        //check for the existance of a water particle emitter and fetch audio source
        if (WaterfallObject != null)
        {
            WaterFallSource = WaterfallObject.GetComponent<AudioSource>();
        }

    }

    void Update()
    {
        //if person collider enters water collider play sound from both emitters
        if (PersonCollider.bounds.Intersects(WaterCollider.bounds) && PlayerInWater != true)
        {
            PlayerInWater = true;
            WaterFallSource.PlayOneShot(WaterfallSound, 0.7F);
            WaterSource.PlayOneShot(WaterSound, 0.5F);
        }
        if (PlayerInWater == true && (!WaterFallSource.isPlaying || !WaterSource.isPlaying))
        {
            if(!WaterFallSource.isPlaying)
            {
                WaterFallSource.PlayOneShot(WaterfallSound, 0.7F);
            }
            if (!WaterSource.isPlaying)
            {
                WaterSource.PlayOneShot(WaterSound, 0.5F);
            }
        }
        else if(!PersonCollider.bounds.Intersects(WaterCollider.bounds))
        {
            PlayerInWater = false;
            WaterFallSource.Stop();
            WaterSource.Stop();


        }
    }
}