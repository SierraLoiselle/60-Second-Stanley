using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMover : MonoBehaviour {

    public GameObject button;
    private double counter1;
    private double counter2;
    // Use this for initialization
    void Start () {
        counter1 = 0;
        counter2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
        counter1++;
        if (counter1 == 60)
        {
            counter1 = 0;
            counter2++;
            if (counter2 == 10)
            {
                button.SetActive(false);
            }
            if (counter2 == 20)
            {
                button.SetActive(true);
                button = GameObject.Find("PushDownButton");
                counter2 = 0;
            }

        }
	}
}
