using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class MenuSceneChanger : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {


    }

    public void StartButton ()
    {
        EditorSceneManager.LoadScene("Locked Room w water and audio");
    }
}
