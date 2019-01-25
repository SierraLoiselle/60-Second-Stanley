using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public GameObject camera;
	// Use this for initialization
	void Start () {
		camera = GameObject.FindGameObjectsWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
