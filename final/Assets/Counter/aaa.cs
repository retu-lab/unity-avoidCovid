using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aaa : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public Text highScore;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        int number = Forever_ShowCount_score2.lastScore2;
        score.text = "Score : " + number.ToString();

        if (number > PlayerPrefs.GetInt("HighScore2", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = "High Score : " + number.ToString();
        }
    }
}
