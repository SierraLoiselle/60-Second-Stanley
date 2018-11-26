using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFood : MonoBehaviour {

    public Rigidbody HamPrefab;

    private Rigidbody HamInstance; 
    
    // Use this for initialization
	void Start () {
        HamInstance = Instantiate(HamPrefab);
        HamInstance.position = new Vector3(0, .05f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
