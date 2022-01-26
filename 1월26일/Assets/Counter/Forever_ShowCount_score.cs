using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 계속 카운터 값을 표시한다
public class Forever_ShowCount_score : MonoBehaviour
{
    [SerializeField] float score = 0;
    [SerializeField] Text scoreText;
    public static int lastScore = 0;
    void Start()// 처음에 시행한다
    {
        scoreText.text = score.ToString();
    }
    void Update()// 계속
    {
        score += Time.deltaTime;
        scoreText.text = Mathf.Round(score).ToString();
        lastScore = (int)Mathf.Round(score);
    }
}
