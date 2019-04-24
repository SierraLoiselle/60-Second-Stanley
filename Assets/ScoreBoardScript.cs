using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreBoardScript : MonoBehaviour {

    public Text[] BestTimesText;
    public Text[] BestNamesText;
    public Text PlayerNumber;
    public Text PlayScore;

    private float[] BestTimes;
    private float[] BestNames;
    private string minutes;
    private string seconds;
    private float holder;

    private void Start()
    {

        holder = PlayerPrefs.GetFloat("TrailNumber");
        PlayerPrefs.SetFloat("TrailNumber", holder);

        BestTimes = new float[6];
        BestTimes = new float[6];

        for (int x = 0; x < BestTimesText.Length; x++)
        {
            BestTimes[x] = PlayerPrefs.GetFloat("highScoreValues" + x);
            BestNames[x] = PlayerPrefs.GetFloat("HighScoreNames" + x);

        }
        DrawScores();
        CheckForHighScore(PlayerPrefs.GetFloat("PlayerScore"), PlayerPrefs.GetFloat("TrailNumber"));
        Debug.Log("scores have been saved");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerPrefs.DeleteAll(); 
            for (int g = 0; g < 6; g++)
            {
                PlayerPrefs.SetFloat("HighScoreNames" + g, 500000000);
            }
            Debug.Log("asfdfj");
        }
    }

    private void SaveScores()
    {
        for (int x = 0; x < BestTimesText.Length; x++)
        {
            PlayerPrefs.SetFloat("highScoreValues" + x, BestTimes[x]);
            PlayerPrefs.SetFloat("HighScoreNames" + x, BestNames[x]);
        }
    }
    public void CheckForHighScore(float value, float Number)
    {
        for (int w = 0; w < BestTimesText.Length; w++)
        {
            if (value > BestTimes[w])
            {
                for (int y = BestTimesText.Length - 1; y > w; y--)
                {
                    BestTimes[y] = BestTimes[y - 1];
                }
                BestTimes[w] = value;
                BestNames[w] = Number;
                DrawScores();
                SaveScores();
                break;
            }
            else if (BestTimes[w] == 0)
            {
                BestTimes[w] = value;
                DrawScores();
                SaveScores();
                break;
            }
        }
    }

    private void DrawScores()
    {
        for (int x = 0; x < BestTimesText.Length; x++)
        {
            minutes = ((int)BestTimes[x] / 60).ToString();
            seconds = (BestTimes[x] % 60).ToString("f2");
            BestTimesText[x].text = minutes + ":" + seconds;
            BestNames[x] = PlayerPrefs.GetFloat("HighScoreNames" + x); 
            
        }

        minutes = ((int)PlayerPrefs.GetFloat("PlayerScore")/ 60).ToString();
        seconds = (PlayerPrefs.GetFloat("PlayerScore") % 60).ToString("f2");
        PlayScore.text = minutes + ":" + seconds;
        PlayerNumber.text = PlayerPrefs.GetFloat("TrailNumber").ToString();
        
    }

}
