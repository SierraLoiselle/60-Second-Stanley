using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {


    public float eatTimeGap;

    private float lastEatTime;
    private int hunger;
   

	// Use this for initialization
	void Start () {
        hunger = 20;
        lastEatTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space"))
        {
            lastEatTime = Time.time;
            
            if (hunger < 20)
            {
                hunger++;
            }
            
        }

        if (eatTimeGap <= Time.time - lastEatTime)
        {
            Debug.Log("time to eat");
            Debug.Log(hunger);
            hunger--;
        }
		
	}
}
