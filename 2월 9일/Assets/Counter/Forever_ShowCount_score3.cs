using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ��� ī���� ���� ǥ���Ѵ�
public class Forever_ShowCount_score3 : MonoBehaviour
{
    [SerializeField] float score3 = 0;
    [SerializeField] Text scoreText3;
    public static int lastScore3 = 0;
    void Start()// ó���� �����Ѵ�
    {
        scoreText3.text = score3.ToString();
    }
    void Update()// ���
    {
        score3 += Time.deltaTime;
        scoreText3.text = Mathf.Round(score3).ToString();
        lastScore3 = (int)Mathf.Round(score3);
    }
}
