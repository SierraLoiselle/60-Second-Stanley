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
            /*PlayerPrefs.DeleteAll();
            for (int g = 0; g < 6; g++)
            {
                PlayerPrefs.SetFloat("HighScoreNames" + g, 500000000);
            }
            */
            Debug.Log("asfdfj");
        }

    }

    public void StartButton ()
    {
        EditorSceneManager.LoadScene("New Scene");
    }
}
