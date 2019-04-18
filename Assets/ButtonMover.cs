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
                button.transform.position = new Vector3(.482f, .267f, 1.906f);
            }
            if (counter2 == 20)
            {
                button.transform.position = new Vector3(-0.012f, .267f, .061f);
                counter2 = 0;
            }

        }
	}
}
