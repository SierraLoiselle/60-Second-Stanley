using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public GameObject cameraRigTransformv;
    public GameObject cameraRigTransformf;
    public GameObject headTransformv;
    public GameObject headTransformf;
    private bool gameMode;
    // Use this for initialization
    void Start () {

		if(cameraRigTransformv.activeInHierarchy == true)
        {
            gameMode = true;
            Debug.Log("AHHHHHHHHHH");
        }
        else
        {
            gameMode = false;
            Debug.Log("ahhhhhhhhhh");
        }
    }

    // Update is called once per frame
    void Update () {
		   
        
      
	}

    public void ToCollectionRoom()
    {

    }
    public void ToLockedRoom()
    {

    }


}
