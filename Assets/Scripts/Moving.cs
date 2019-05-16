using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public GameObject cameraRigTransformv;
    public GameObject cameraRigTransformf;
    public bool room;
    public bool first;
    //false = locked room
    // true = collection room
    private bool gameMode;
    // Use this for initialization
    void Start () {
        room = false;
        first = true;
		if(cameraRigTransformv.activeSelf == true)
        {
            gameMode = true;
            
        }
        else
        {
            gameMode = false;
           
        }
    }

    // Update is called once per frame
    void Update () {

        if (cameraRigTransformv.activeSelf == true)
        {
            gameMode = true;
           
        }

    }

    public void ToCollectionRoom()
    {
        if(gameMode == true)
        {
            cameraRigTransformv.transform.position = new Vector3(-53.5f, 1.95f, -25.346f);
            room = true;
        }
        else
        {
            cameraRigTransformf.transform.position = new Vector3(-53.5f, 1.95f, -25.346f);
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
            GameObject.Find("this makes the food").GetComponent<MakeFood>().SpawnFood();

        }
        else if(cameraRigTransformf.transform.position.x == 0 && gameMode == false){
            ToCollectionRoom();
            GameObject.Find("this makes the food").GetComponent<MakeFood>().SpawnFood();
        }
        else
        {
            ToLockedRoom();
        }
    }


}
