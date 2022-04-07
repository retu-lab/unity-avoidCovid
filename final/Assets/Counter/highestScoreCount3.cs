using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class highestScoreCount3 : MonoBehaviour
{
    public InputField HS3;
    public static int Score3 = showScore2.lastCount;
    // public Text scoreText = showScore.Score;
   // public Text highScoreText;

    int savedScore3 = 0;
    string KeyString3 = "HighScoreThree";

    void Awake()
    {
        savedScore3 = PlayerPrefs.GetInt(KeyString3);
        //highScoreText.text = "High Score : " + savedScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
       // scoreText.text = "Score : " + Score.ToString("0");

    }
    void Update()
    {
        if (Score3 >= savedScore3)
        {
            PlayerPrefs.SetInt(KeyString3, Score3);
        }
        PlayerPrefs.Save();

        HS3.text = "High Score : " + savedScore3.ToString();
    }
}
