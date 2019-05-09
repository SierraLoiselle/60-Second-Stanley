using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeGapSetter : MonoBehaviour
{

    public Slider mainSlider;
    public int setting;

    // Use this for initialization
    void Start()
    {
        setting = 1;
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Update is called once per frame
    void Update()
    {

    }

   // public void SetTimeGap()
   // {
     //   m_Dropdown = GetComponent<Dropdown>();
     //
       // if (m_Dropdown.value == 1)
        //{
          //  PlayerPrefs.SetInt("TimeGap", 5);
            //Debug.Log("ahh");
            //Debug.Log(PlayerPrefs.GetInt("TimeGap"));
        //}
        //else if (m_Dropdown.value == 2)
        //{
          //  PlayerPrefs.SetInt("TimeGap", 3);
            //Debug.Log(PlayerPrefs.GetInt("TimeGap"));
            //Debug.Log("ahh");
        //}
        //else if (m_Dropdown.value == 3)
        //{
          //  PlayerPrefs.SetInt("TimeGap", 1);
            //Debug.Log("ahh");
           // Debug.Log(PlayerPrefs.GetInt("TimeGap"));
        //}
    //}
    public void ValueChangeCheck()
    {
        Debug.Log(mainSlider.value);
        float i = mainSlider.GetComponent<Slider>().value;
        if (i == 0)
        {
            PlayerPrefs.SetInt("TimeGap", 5);
        };
        if(i == 1)
        {
            PlayerPrefs.SetInt("TimeGap", 3);
        }
        if(i == 2)
        {
            PlayerPrefs.SetInt("TimeGape", 1);
        }
    }

}

