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
        PlayerPrefs.SetFloat("TrailNumber", holder + 1);


        BestTimes = new float[5];
        BestNames = new float[5];

        Debug.Log(holder);

        for (int x = 0; x < BestTimesText.Length; x++)
        {
            BestTimes[x] = PlayerPrefs.GetFloat("highScoreValues" + x);
        
            BestNames[x] = PlayerPrefs.GetFloat("HighScoreNames" + x);
            
        }
        DrawScores();
        CheckForHighScore(PlayerPrefs.GetFloat("PlayerScore"), PlayerPrefs.GetFloat("TrailNumber"));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll(); 
            for (int g = 0; g < 5; g++)
            {
                BestNames[g] = 0;
                BestTimes[g] = 0; 
                //PlayerPrefs.SetFloat("HighScoreNames" + g, 0);
                //PlayerPrefs.SetFloat("highScoreValues" + g, 0);
                PlayerPrefs.SetFloat("TrailNumber", 0);
                PlayerPrefs.SetFloat("TimeGap", 1);

            }
            SaveScores();
            DrawScores();
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
                    BestNames[y] = BestNames[y - 1];
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
                BestNames[w] = Number;
                DrawScores();
                SaveScores();
                break;
            }
        }
    }

    private void DrawScores()
    {
        for (int x = 0; x < 5; x++)
        {
            minutes = ((int)BestTimes[x] / 60).ToString();
            seconds = (BestTimes[x] % 60).ToString("f2");
            BestTimesText[x].text = minutes + ":" + seconds;
            BestNamesText[x].text = BestNames[x].ToString(); 
            
        }

        minutes = ((int)PlayerPrefs.GetFloat("PlayerScore")/ 60).ToString();
        seconds = (PlayerPrefs.GetFloat("PlayerScore") % 60).ToString("f2");
        PlayScore.text = minutes + ":" + seconds;
        PlayerNumber.text = (PlayerPrefs.GetFloat("TrailNumber")).ToString();
        
    }

}
