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
        ValueChangeCheck();
    }
    public void ValueChangeCheck()
    {
        Debug.Log(mainSlider.value);
        float i = mainSlider.GetComponent<Slider>().value;
        if (i == 0)
        {
            PlayerPrefs.SetInt("TimeGap", 5);
            setting = 5;
        };
        if(i == 1)
        {
            PlayerPrefs.SetInt("TimeGap", 3);
            setting = 3;
        }
        if(i == 2)
        {
            PlayerPrefs.SetInt("TimeGape", 1);
            setting = 1;

        }
    }

}

