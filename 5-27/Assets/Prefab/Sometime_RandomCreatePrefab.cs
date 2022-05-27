using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_RandomCreatePrefab : MonoBehaviour
{
    public GameObject newPrefab;
    public float intervalSec = 1;
    public int faster = 0;

    void Start()
    {
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    int flag = 0;
    int count = 0;
    void FixedUpdate()
    {
        faster = Forever_ShowCount_score.lastScore;
        if (faster % 10 == 1) flag = 0;
        if (faster >= 10 && faster % 10 == 0)
        {
            if (count < 10 && flag == 0 && intervalSec > 0.1)
            {
                intervalSec -= (float)0.05;
                flag = 1;
                count++;
            }
        }

    }

    void CreatePrefab()
    {

        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = -5;

        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.position = newPos;
    }

}
