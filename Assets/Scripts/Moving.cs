using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public GameObject cameraRigTransformv;
    public GameObject cameraRigTransformf;
    public bool room;
    //false = locked room
    // true = collection room
    private bool gameMode;
    // Use this for initialization
    void Start () {
        room = false;
		if(cameraRigTransformv.activeSelf == true)
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

        if (cameraRigTransformv.activeSelf == true)
        {
            gameMode = true;
            Debug.Log("AHHHHHHHHHH");
        }

    }

    public void ToCollectionRoom()
    {
        if(gameMode == true)
        {
            cameraRigTransformv.transform.position = new Vector3(-53.5f, 2.056f, -25.346f);
            room = true;
        }
        else
        {
            cameraRigTransformf.transform.position = new Vector3(-53.5f, 2.056f, -25.346f);
            room = true;
        }

    }
    public void ToLockedRoom()
    {
        if (gameMode == true)
        {
            cameraRigTransformv.transform.position = new Vector3(0f, 0f, 0f);
            room = false;
        }
        else
        {
            cameraRigTransformf.transform.position = new Vector3(0f, 0f, 0f);
            room = false;
        }
    }
    public void PickingRoom()
    {
        if(cameraRigTransformv.transform.position.x == 0 && gameMode == true)
        {
            ToCollectionRoom();
            
        }
        else if(cameraRigTransformf.transform.position.x == 0 && gameMode == false){
            ToCollectionRoom();
           
        }
        else
        {
            ToLockedRoom();
        }
    }


}
