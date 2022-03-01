using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item1_delete : MonoBehaviour
{
	public string targetObjectName; // 목표 오브젝트 이름 : Inspector에 지정

	void OnCollisionEnter2D(Collision2D collision)// 충돌했을 때
	{
		// 상대와 자신을 삭제한다 
		if (collision.gameObject.name == targetObjectName)
		{
            //SoundManagerScript.PlaySound("heart");
			Destroy(this.gameObject);
			if(OnCollision_SwitchScene.hp < 3)
				OnCollision_SwitchScene.hp++; 
		}
	}
}
