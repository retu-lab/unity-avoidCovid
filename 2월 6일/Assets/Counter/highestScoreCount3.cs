using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class highestScoreCount3 : MonoBehaviour
{
    [SerializeField] Text HS3;
    public static int Score3 = Forever_ShowCount_score3.lastScore3;
    // public Text scoreText = showScore.Score;
   // public Text highScoreText;

    private int savedScore3 = 0;
    private string KeyString3 = "HighScore3";

    void Awake()
    {
        //savedScore3 = PlayerPrefs.GetInt(KeyString3, 0);
        //highScoreText.text = "High Score : " + savedScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
       // scoreText.text = "Score : " + Score.ToString("0");
        //savedScore3 = PlayerPrefs.GetInt(KeyString3, 0);
        if (Score3 > savedScore3)
        {
            PlayerPrefs.SetInt(KeyString3, Score3);
            savedScore3 = PlayerPrefs.GetInt(KeyString3, 0);
        }
        HS3.text = "High Score : " + savedScore3.ToString();
    }
}
