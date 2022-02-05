using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        int a = OnCollision_SwitchScene.hp;
        if (a == 3)
        {
            if(gameObject.activeSelf == false)
                this.gameObject.SetActive(true);
        }
        else
            this.gameObject.SetActive(false);

    }
}
