using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreBoardScript : MonoBehaviour {

    //CheckForHighScore (totalClicks, PlayerName.text);
    public Text[] BestTimesText;
    //public Text[] BestNamesText;
    public Text PlayerName;
    public InputField Name; 

    private float[] BestTimes;
    //private Text[] BestNamesPrivate;

    private void Start()
    {

    }

    private void SaveScores()
    {
        for (int x = 0; x < BestTimesText.Length; x++)
        {
            PlayerPrefs.SetFloat("highScoreValues" + x, BestTimes[x]);
            //PlayerPrefs.SetString("highScoreNames" + x, BestNamesPrivate[x].ToString());
        }
    }
    public void CheckForHighScore(float value)
    {
        for (int w = 0; w < BestTimesText.Length; w++)
        {
            if (value < BestTimes[w])
            {
                for (int y = BestTimesText.Length - 1; y > w; y--)
                {
                    BestTimes[y] = BestTimes[y - 1];
                }
                BestTimes[w] = value;
                //BestNamesPrivate[w] = name;
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
            string minutes = ((int)BestTimes[x] / 60).ToString();
            string seconds = (BestTimes[x] % 60).ToString("f2");
            BestTimesText[x].text = minutes + ":" + seconds;
           // BestNamesText[x] = PlayerName; 
            
        }
    }

    public void NameWasEntered()
    {
        //PlayerName.text = Name.text;
        //setting size
        BestTimes = new float[6];
        for (int x = 0; x < BestTimesText.Length; x++)
        {
            BestTimes[x] = PlayerPrefs.GetFloat("highScoreValues" + x);
            //BestNamesPrivate[x].text = PlayerPrefs.GetString("highScoreNames" + x);
            
        }
        DrawScores();
        CheckForHighScore(PlayerPrefs.GetFloat("PlayerScore"));
    }

}
