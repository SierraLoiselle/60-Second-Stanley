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
    private GameObject food;
    


    void Start () {


        updtCount = 0;
		
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
            for (int x = 0; x < foods.Length; x++)
            {
                Debug.Log("length = " + foods.Length.ToString());
                Debug.Log("currentX = " + x.ToString());
                food = foods[x];
                tempFood = food.GetComponent<Collider>();
                audioSource = food.GetComponent<AudioSource>();
                if (tempFood.bounds.Intersects(tileCollider.bounds))
                {
                    Debug.Log("Food is Intersecting with water");
                    if (BoolsForFood[x] == false)
                    {
                        audioSource.PlayOneShot(audioClip, 0.5f);
                        BoolsForFood[x] = true;
                        Debug.Log("Audio is playing");
                    } 
                }
                else if (!tempFood.bounds.Intersects(tileCollider.bounds))
                {
                    Debug.Log("Food is not intersecting with water");
                    BoolsForFood[x] = false;
                }
            }
            
            Debug.Log("counter after reset = " + counter.ToString());
        }
        

	}
}
