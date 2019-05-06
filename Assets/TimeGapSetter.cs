using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeGapSetter : MonoBehaviour {

    public Dropdown m_Dropdown;
    
    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetTimeGap ()
    {
        m_Dropdown = GetComponent<Dropdown>();

        if (m_Dropdown.value == 1)
        {
            PlayerPrefs.SetInt("TimeGap", 5);
        }
        else if (m_Dropdown.value == 2)
        {
            PlayerPrefs.SetInt("TimeGap", 3);
        }
        else if (m_Dropdown.value == 3)
        {
            PlayerPrefs.SetInt("TimeGap", 1);
        }
    }
}
