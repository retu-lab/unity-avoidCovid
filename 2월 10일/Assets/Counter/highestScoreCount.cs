using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class highestScoreCount : MonoBehaviour
{
    [SerializeField] Text HS;
    public static int Score = Forever_ShowCount_score.lastScore;
    // public Text scoreText = showScore.Score;
   // public Text highScoreText;

    private int savedScore = 0;
    private string KeyString = "HighScore";

    void Awake()
    {
        savedScore = PlayerPrefs.GetInt(KeyString, 0);
        //highScoreText.text = "High Score : " + savedScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        // scoreText.text = "Score : " + Score.ToString("0");
        //PlayerPrefs.DeleteAll();
        if (Score > savedScore)
        {
            PlayerPrefs.SetInt(KeyString, Score);
        }
        HS.text = "High Score : " + savedScore.ToString();
    }
}
