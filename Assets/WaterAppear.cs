using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAppear : MonoBehaviour {

    public GameObject water;
    private GameObject oil;
    public GameObject waterbase;
    public bool IsThereWater;
    // Use this for initialization
	void Start () {
        IsThereWater = false;
        oil = Instantiate(water);
        IsThereWater = true;

        //oil.position = new Vector3()
	}
	
	// Update is called once per frame
	void Update () {
        if(IsThereWater == true)
        {
            waterbase = GetComponent(FluvioWater4");
            waterbase.transform.position = new Vector3(0, 1, 0);
        }
	}

    
}
