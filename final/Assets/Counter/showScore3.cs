using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore3 : MonoBehaviour
{
    public int lastCount;
    [SerializeField] Text Score;
    void Start()
    {
        lastCount = Forever_ShowCount_score3.lastScore3;
        Score.text = "score : " + lastCount.ToString();
    }

}
