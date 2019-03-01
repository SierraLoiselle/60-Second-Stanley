using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollisionScript : MonoBehaviour {  
  // Use this for initialization

    public GameObject[] foods;
    private Collider tempFood;
    public GameObject tile;
    private Collider tileCollider;
    private AudioSource audioSource;
    public AudioClip audioClip;
    private List<bool> BoolsForFood;
    private int counter;
    private int updtCount;
    


    void Start () {
        


		
	}
	
	// Update is called once per frame
	void Update () {
        updtCount++;

        if (updtCount == 30)
        {
            counter = 0;
            BoolsForFood = new List<bool>();
            if (foods != null)
            {
                foods = GameObject.FindGameObjectsWithTag("Food");
                Debug.Log(foods.Length.ToString() + " objects found");
                foreach (GameObject food in foods)
                {
                    BoolsForFood.Add(false);

                }
                Debug.Log(BoolsForFood.ToArray().Length.ToString() + " bools created");
            }
            if (tile != null)
            {
                tileCollider = tile.GetComponent<Collider>();
                Debug.Log("tile collider found and assigned");
            }
        }
        if (updtCount > 30)
        {
            foreach (GameObject food in foods)
            {
                Debug.Log("length = " + foods.Length.ToString());
                tempFood = food.GetComponent<Collider>();
                audioSource = food.GetComponent<AudioSource>();
                Debug.Log("counter = " + counter.ToString());
                if (tempFood.bounds.Intersects(tileCollider.bounds) && BoolsForFood[counter] == false)
                {
                    Debug.Log("Food is Intersecting with water");
                    audioSource.PlayOneShot(audioClip, 0.5f);
                    Debug.Log("Audio is playing");
                    BoolsForFood[counter] = true;
                }
                else if (!tempFood.bounds.Intersects(tileCollider.bounds))
                {
                    Debug.Log("Food is not intersecting with water");
                    BoolsForFood[counter] = false;
                }
                if(foods.Length == counter)
                {
                    Debug.Log("Attempt Break");
                    break;
                }
                counter++;
            }
            counter = 0;
            Debug.Log("counter after reset = " + counter.ToString());
        }
        

	}
}
