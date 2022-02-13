using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore1 : MonoBehaviour
{
    public int lastCount;
    [SerializeField] Text Score;
    void Start()
    {
        lastCount = Forever_ShowCount_score1.lastScore1;
        Score.text = "score : " + lastCount.ToString();
    }

}
