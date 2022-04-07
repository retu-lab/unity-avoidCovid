using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour
{
    public int lastCount;
    [SerializeField] Text Score;
    void Start()
    {
        lastCount = Forever_ShowCount_score.lastScore;
        Score.text = "score : " + lastCount.ToString();
    }

}
