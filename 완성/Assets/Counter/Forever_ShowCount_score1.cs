using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 계속 카운터 값을 표시한다
public class Forever_ShowCount_score1 : MonoBehaviour
{
    [SerializeField] float score1 = 0;
    [SerializeField] Text scoreText1;
    public static int lastScore1 = 0;
    void Start()// 처음에 시행한다
    {
        scoreText1.text = score1.ToString();
    }
    void Update()// 계속
    {
        score1 += Time.deltaTime;
        scoreText1.text = Mathf.Round(score1).ToString();
        lastScore1 = (int)Mathf.Round(score1);
    }
}
