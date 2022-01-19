using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon_collide_obake : MonoBehaviour
{
    public string targetObjectName; // 목표 오브젝트 이름 : Inspector에 지정
   //

    void OnCollisionEnter2D(Collision2D collision)// 충돌했을 때
    {
        // 상대와 자신을 삭제한다 
        if (collision.gameObject.name == targetObjectName)
        {
            Destroy(this.gameObject, 0.1f);
            Destroy(gameObject, 0.1f);
            this.gameObject.SetActive(false);
        }
    }
}
