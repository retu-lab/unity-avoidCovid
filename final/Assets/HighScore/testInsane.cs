using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testInsane : MonoBehaviour
{
    public Text score;
    //public Text HS;
    public int savedHighScore = 0;
    public int curScore = 0;


    void Start()
    {
        curScore = Forever_ShowCount_score3.lastScore3;
        savedHighScore = PlayerPrefs.GetInt("highScoreInsane", 0);

        if (curScore > savedHighScore)
        {
            PlayerPrefs.SetInt("highScoreInsane", curScore);
        }
        score.text = "Score : " + curScore.ToString();
        // HS.text = "High Score : " + savedHighScore.ToString();
    }



}
