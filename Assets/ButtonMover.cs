using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMover : MonoBehaviour {

    public GameObject button;
    private GameObject buttonInstance;
    private List<Rigidbody> buttonStuff = new List<Rigidbody>();
    private double counter1;
    private double counter2;
    // Use this for initialization
    void Start () {
        counter1 = 0;
        counter2 = 0;
        buttonInstance = button;
        buttonInstance.transform.position = new Vector3(.477f, .934f, -1.015f);
        //buttonInstance.transform.rotation = new Vector3(0, 90,90);
        Instantiate(buttonInstance);
        //buttonStuff.Add(buttonInstance);
        

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
                Debug.Log("should delete");
                buttonInstance = GameObject.Find("PushDownButton(Clone)");
                Destroy(buttonInstance);
            }
            if (counter2 == 20)
            {
                buttonInstance = button;
                buttonInstance.transform.position = new Vector3(.477f, .934f, -1.015f);
                //buttonInstance.transform.rotation = new Vector3(0, 90,90);
                Instantiate(buttonInstance);
                //buttonStuff.Add(buttonInstance);
                counter2 = 0;
            }
            

        }
	}
}
