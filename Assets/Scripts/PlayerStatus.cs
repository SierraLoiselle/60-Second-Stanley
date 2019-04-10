using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public bool room;
    public bool gameover;

    public Text collectiontext;
    public float collectiontimer;
    public bool first;
    AudioSource audioSource;

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
        audioSource = GameObject.Find("Stats").GetComponent<AudioSource>();
        first = GameObject.Find("PlayerMover").GetComponent<Moving>().first;
        gameover = false;
    }
	
	// Update is called once per frame
	void Update () {

        room = GameObject.Find("PlayerMover").GetComponent<Moving>().room;
        if (Time.time - lastUWTime >= 1)
        {
            lastUWTime--;
            if(room == true && first != true && !audioSource.isPlaying)
            {
                collectiontimer--;
                Debug.Log("AHHH");
                if (collectiontimer == 0)
                {
                    SceneManager.LoadScene("Score Board");
                }
            }
            else
            {
                collectiontimer = 20;
            }
            if(first == true)
            {
                audioSource.Play();
                first = false;
            }
        }
        if (Time.time - lastDrinkTime >= drinkTimeGap && room == false)
        {
            thirst--;
            lastDrinkTime = Time.time;
        }
        if (eatTimeGap <= Time.time - lastEatTime && room == false)
        {
            hunger--;
            lastEatTime = Time.time;
        }
        if (1 <= Time.time - lastBreath && waterbase.transform.position.y > 1.283 && room == false )
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
            gameover = true;
            SceneManager.LoadScene("Score Board");


        }
        else
        {
            alive.text = "YOU ALIVE";
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
        collectiontext.text = collectiontimer.ToString();
    }


}
