using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAppear : MonoBehaviour {

    public GameObject water;
    private GameObject oil;
    public GameObject waterbase;
    public bool IsThereWater;
    public bool room;
    // Use this for initialization
	void Start () {
        IsThereWater = false;
        oil = Instantiate(water);
        IsThereWater = true;
        waterbase = GameObject.Find("FluvioWater4");

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
	}

    
}
