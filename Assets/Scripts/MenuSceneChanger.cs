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
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("All the stuff has been reset");
        }

    }

    public void StartButton ()
    {
        EditorSceneManager.LoadScene("New Scene");
    }
    public void SettingButton()
    {
        EditorSceneManager.LoadScene("Setting Menu");
    }
}
