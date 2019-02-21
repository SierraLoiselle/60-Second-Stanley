using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCollisionScript : MonoBehaviour {

    // Use this for initialization
    public GameObject[] foods;
    private Collider tempFood;
    public GameObject tile;
    private Collider tileCollider;
    private AudioSource owo;


    void Start () {
        if(foods==null)
        {
            foods = GameObject.FindGameObjectsWithTag("Food");
        }
        if(tile!=null)
        {
            tileCollider = tile.GetComponent<Collider>();
        }

		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject food in foods)
        {
            tempFood = food.GetComponent<Collider>();
            owo = food.GetComponent<>
            if (tempFood.bounds.Intersects(tileCollider.bounds))
            {

            }
        }
	}
}
