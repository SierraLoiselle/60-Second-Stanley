using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {


    }

    public void StartButton ()
    {
        EditorSceneManager.LoadScene("Collection Room");
    }
}
