using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon_collide_obake : MonoBehaviour
{
    public string targetObjectName; // ��ǥ ������Ʈ �̸� : Inspector�� ����
   //

    void OnCollisionEnter2D(Collision2D collision)// �浹���� ��
    {
        // ���� �ڽ��� �����Ѵ� 
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(this.gameObject, 0.1f);
            Destroy(gameObject, 0.1f);
            this.gameObject.SetActive(false);
        }
    }
}
