using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obake_delete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

    }
    void OnTriggerStay2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
