using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �浹�ϸ� �ڱ��ڽ��� �����Ѵ� 
public class OnCollision2 : MonoBehaviour
{

	//public GameObject targetObject; // ��ǥ ������Ʈ �̸� : Inspector�� ����

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
