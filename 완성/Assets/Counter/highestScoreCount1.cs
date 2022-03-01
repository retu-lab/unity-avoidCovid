using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class highestScoreCount1 : MonoBehaviour
{
    [SerializeField] Text HS1;
    public static int Score1 = Forever_ShowCount_score1.lastScore1;
    // public Text scoreText = showScore.Score;
   // public Text highScoreText;

    private int savedScore1 = 0;
    private string KeyString1 = "HighScore1";

    void Awake()
    {
        savedScore1 = PlayerPrefs.GetInt(KeyString1, 0);
        //highScoreText.text = "High Score : " + savedScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
       // scoreText.text = "Score : " + Score.ToString("0");

        if (Score1 > savedScore1)
        {
            PlayerPrefs.SetInt(KeyString1, Score1);
        }
        HS1.text = "High Score : " + savedScore1.ToString();
    }
}
