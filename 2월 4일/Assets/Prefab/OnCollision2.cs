using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 충돌하면 자기자신을 삭제한다 
public class OnCollision2 : MonoBehaviour
{

	//public GameObject targetObject; // 목표 오브젝트 이름 : Inspector에 지정

	void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Bullet")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }

}
