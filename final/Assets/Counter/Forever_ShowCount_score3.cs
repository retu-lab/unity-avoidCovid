using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 계속 카운터 값을 표시한다
public class Forever_ShowCount_score3 : MonoBehaviour
{
    [SerializeField] float score3 = 0;
    [SerializeField] Text scoreText3;
    public static int lastScore3 = 0;
    void Start()// 처음에 시행한다
    {
        scoreText3.text = score3.ToString();
    }
    void Update()// 계속
    {
        score3 += Time.deltaTime;
        scoreText3.text = Mathf.Round(score3).ToString();
        lastScore3 = (int)Mathf.Round(score3);
    }
}
