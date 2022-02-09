using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Turn : MonoBehaviour
{
    public float angle = 80;
    public int maxCount = 10;

    int count = 0;
    void Start()
    {
        count = 0;
    }

    
    void FixedUpdate()
    {
        count++;
        if(count >= maxCount)
        {
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
    }
}
