using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int a = OnCollision_SwitchScene.hp;
        if (a >= 1)
            this.gameObject.SetActive(true);
        else
            this.gameObject.SetActive(false);
    }
}
