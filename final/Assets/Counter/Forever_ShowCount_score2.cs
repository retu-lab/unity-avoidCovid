using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ��� ī���� ���� ǥ���Ѵ�
public class Forever_ShowCount_score2 : MonoBehaviour
{
    [SerializeField] float score2 = 0;
    [SerializeField] Text scoreText2;
    public static int lastScore2 = 0;
    void Start()// ó���� �����Ѵ�
    {
        scoreText2.text = score2.ToString();
    }
    void Update()// ���
    {
        score2 += Time.deltaTime;
        scoreText2.text = Mathf.Round(score2).ToString();
        lastScore2 = (int)Mathf.Round(score2);
    }
}
