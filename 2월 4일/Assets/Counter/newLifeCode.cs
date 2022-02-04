using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLifeCode : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int n = OnCollision_SwitchScene.hp;
        if (n == 3)
        {
            a1.SetActive(true);
            a2.SetActive(true);
            a3.SetActive(true);

        }
        if (n == 2)
        {
            a1.SetActive(false);
            a2.SetActive(true);
            a3.SetActive(true);

        }
        if (n == 1)
        {
            a1.SetActive(false);
            a2.SetActive(false);
            a3.SetActive(true);

        }
        if (n == 0)
        {
            a1.SetActive(false);
            a2.SetActive(false);
            a3.SetActive(false);

        }
    }
}
