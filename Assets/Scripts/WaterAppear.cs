using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaterAppear : MonoBehaviour {

    public GameObject water;
    public Text Timer;
    public float startime;
    private GameObject oil;
    public GameObject waterbase;
    public bool IsThereWater;
    public bool room;
    private float t; 
    // Use this for initialization
	void Start () {
        IsThereWater = false;
        oil = Instantiate(water);
        IsThereWater = true;
        waterbase = GameObject.Find("FluvioWater4");
        startime = Time.time;

        //oil.position = new Vector3()
    }
	
	// Update is called once per frame
	void Update () {
        room = GameObject.Find("PlayerMover").GetComponent<Moving>().room;
        if (IsThereWater == true && room == false)
        {
            float i = waterbase.transform.position.y;
            i = i + .0001f;
            waterbase.transform.position = new Vector3(0, i, 0);
        }
        //player prefs are vars that are saved within the game, this is making a playerpref called playertime and assigning it the value of time - startime
        //This can be chnaged it is what is going to be stored as the time they they player took to die jkdrjfjaa fj
        
        t = Time.time - startime;
        PlayerPrefs.SetFloat("PlayerScore", t);
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        Timer.text = minutes + ":" + seconds;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Score Board");

        }
	}

    
}
