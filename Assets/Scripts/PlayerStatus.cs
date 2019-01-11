using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour {


    public Text hungertext;
    public Text thirsttext;
    public Text drowningtext;
    public float eatTimeGap;
    public float drinkTimeGap;
    public float hunger;
    public float thirst;
    public float drowning;

    private float lastEatTime;
    private float lastDrinkTime;
    private float lastUWTime;



    // Use this for initialization
    void Start () {
        hunger = 20;
        thirst = 20;
        drowning = 15;
        lastEatTime = Time.time;
        lastDrinkTime = Time.time;
        lastUWTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {


        if (Time.time - lastUWTime >= 1)
        {
            lastUWTime--;
        }
        if (Time.time - lastDrinkTime >= drinkTimeGap)
        {
            thirst--;
        }
        if (eatTimeGap <= Time.time - lastEatTime)
        {
            hunger--;
            lastEatTime = Time.time;
            Debug.Log("WTF");
        }

        if (hunger <= 0 || thirst <= 0 || drowning <= 0)
        {
            Debug.Log("you are dead");
        }    
        
       
        DisplayScores();
		
	}

    public void EatButton ()
    {
        hunger++;
        Debug.Log("hunger has gone up");
    }


    private void DisplayScores ()
    {
        hungertext.text = "hunger is " + hunger.ToString();
        thirsttext.text = "thirst is " + thirst.ToString();
        drowningtext.text ="drowning time is " + drowning.ToString();
    }


}
