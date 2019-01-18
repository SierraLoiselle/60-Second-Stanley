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
    public GameObject waterbase;

    private float lastEatTime;
    private float lastDrinkTime;
    private float lastBreath;
    private float lastUWTime;



    // Use this for initialization
    void Start () {
        lastEatTime = Time.time;
        lastDrinkTime = Time.time;
        lastUWTime = Time.time;
        lastBreath = Time.time;
        waterbase = GameObject.Find("FluvioWater4");
    }
	
	// Update is called once per frame
	void Update () {


        if (Time.time - lastUWTime >= 1)
        {
            lastUWTime--;
        }
        if (Time.time - lastDrinkTime >= drinkTimeGap)
        {
            //thirst--;
            lastDrinkTime = Time.time;
        }
        if (eatTimeGap <= Time.time - lastEatTime)
        {
            hunger--;
            lastEatTime = Time.time;
        }
        if (1 <= Time.time - lastBreath && waterbase.transform.position.y > 1.283 )
        {
            drowning--;
            lastBreath = Time.time;
        }
        if(waterbase.transform.position.y < 1.283 && drowning != 20)
        {
            drowning = 20;
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
