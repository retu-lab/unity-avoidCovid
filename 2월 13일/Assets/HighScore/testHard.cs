using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testHard : MonoBehaviour
{
    public Text score;
    //public Text HS;
    public int savedHighScore = 0;
    public int curScore = 0;


    void Start()
    {
        curScore = Forever_ShowCount_score2.lastScore2;
        savedHighScore = PlayerPrefs.GetInt("highScoreHard", 0);

        if (curScore > savedHighScore)
        {
            PlayerPrefs.SetInt("highScoreHard", curScore);
        }
        score.text = "Score : " + curScore.ToString();
        // HS.text = "High Score : " + savedHighScore.ToString();
    }



}
