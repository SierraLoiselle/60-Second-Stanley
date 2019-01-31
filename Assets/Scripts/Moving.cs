using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public GameObject cameraRigTransformv;
    public GameObject cameraRigTransformf;
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
        if(gameMode == true)
        {
            cameraRigTransformv.transform.position = new Vector3(-52.635f, 1.28f, -25.355f);
        }
        else
        {
            cameraRigTransformf.transform.position = new Vector3(-52.63f, 1.28f, -25.355f);
        }

    }
    public void ToLockedRoom()
    {
        if (gameMode == true)
        {
            cameraRigTransformv.transform.position = new Vector3(0f, 0f, 0f);
        }
        else
        {
            cameraRigTransformf.transform.position = new Vector3(0f, 0f, 0f);
        }
    }
    public void PickingRoom()
    {
        if(cameraRigTransformv.transform.position.y == 0 || cameraRigTransformf.transform.position.y == 0)
        {
            ToCollectionRoom();
        }
        else
        {
            ToLockedRoom();
        }
    }


}
