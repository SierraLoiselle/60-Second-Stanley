using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    public GameObject cameraRigTransformv;
    public GameObject cameraRigTransformf;
    private bool gameMode;
    // Use this for initialization
    void Start () {

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
            cameraRigTransformv.transform.position = new Vector3(-54.683f, 1.953897f, -24.799f);
        }
        else
        {
            cameraRigTransformf.transform.position = new Vector3(-54.683f, 1.953897f, -24.799f);
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
