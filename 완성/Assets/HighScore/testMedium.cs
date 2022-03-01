using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testMedium : MonoBehaviour
{
    public Text score;
    //public Text HS;
    public int savedHighScore = 0;
    public int curScore = 0;


    void Start()
    {
        curScore = Forever_ShowCount_score1.lastScore1;
        savedHighScore = PlayerPrefs.GetInt("highScoreMedium", 0);

        if (curScore > savedHighScore)
        {
            PlayerPrefs.SetInt("highScoreMedium", curScore);
        }
        score.text = "Score : " + curScore.ToString();
        // HS.text = "High Score : " + savedHighScore.ToString();
    }



}
