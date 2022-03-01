using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class highestScoreCount2 : MonoBehaviour
{
    public Text HS2;
    public static int Score2 = Forever_ShowCount_score2.lastScore2;
    // public Text scoreText = showScore.Score;
   // public Text highScoreText;

    private int savedScore2 = 0;
    private string KeyString2 = "HighScore2";

    void Awake()
    {
        savedScore2 = PlayerPrefs.GetInt(KeyString2, 0);
        //highScoreText.text = "High Score : " + savedScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
       // scoreText.text = "Score : " + Score.ToString("0");

        if (Score2 > savedScore2)
        {
            PlayerPrefs.SetInt(KeyString2, Score2);
        }
        HS2.text = "High Score : " + savedScore2.ToString();
    }
}
