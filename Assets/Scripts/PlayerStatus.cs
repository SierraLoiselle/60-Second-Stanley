using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour {


    public Text hungertext;
    public Text thirsttext;
    public Text drowningtext;
    public Text alive;
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
            lastDrinkTime = Time.time;
        }
        if (eatTimeGap <= Time.time - lastEatTime)
        {
            hunger--;
            lastEatTime = Time.time;
        }

        if (hunger <= 0 || thirst <= 0 || drowning <= 0)
        {
            alive.text = "YOU IS DED!!!!!!!";
            hungertext.text = "DED";
            thirsttext.text = "DED";
            drowningtext.text = "DEAD";


        }


        DisplayScores();
		
	}

    public void EatButton ()
    {
        hunger = 20;
    }

    public void DrinkButton()
    {
        thirst = 20;
    }



    private void DisplayScores ()
    {
        hungertext.text = "hunger is " + hunger.ToString();
        thirsttext.text = "thirst is " + thirst.ToString();
        drowningtext.text ="drowning time is " + drowning.ToString();
    }


}
