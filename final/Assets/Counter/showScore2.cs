using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore2 : MonoBehaviour
{
    public static int lastCount;
    public Text Score;
    void Start()
    {
        lastCount = Forever_ShowCount_score2.lastScore2;
        Score.text = "score : " + lastCount.ToString();
    }

}
