using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ��� ī���� ���� ǥ���Ѵ�
public class Forever_ShowCount_score1 : MonoBehaviour
{
    [SerializeField] float score1 = 0;
    [SerializeField] Text scoreText1;
    public static int lastScore1 = 0;
    void Start()// ó���� �����Ѵ�
    {
        scoreText1.text = score1.ToString();
    }
    void Update()// ���
    {
        score1 += Time.deltaTime;
        scoreText1.text = Mathf.Round(score1).ToString();
        lastScore1 = (int)Mathf.Round(score1);
    }
}
