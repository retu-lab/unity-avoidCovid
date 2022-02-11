using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 계속 카운터 값을 표시한다
public class Forever_ShowCount_score2 : MonoBehaviour
{
    [SerializeField] float score2 = 0;
    [SerializeField] Text scoreText2;
    public static int lastScore2 = 0;
    void Start()// 처음에 시행한다
    {
        scoreText2.text = score2.ToString();
    }
    void Update()// 계속
    {
        score2 += Time.deltaTime;
        scoreText2.text = Mathf.Round(score2).ToString();
        lastScore2 = (int)Mathf.Round(score2);
    }
}
