using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item3_delete : MonoBehaviour
{
	public string targetObjectName; // ��ǥ ������Ʈ �̸� : Inspector�� ����

	void OnCollisionEnter2D(Collision2D collision)// �浹���� ��
	{
		// ���� �ڽ��� �����Ѵ� 
		if (collision.gameObject.name == targetObjectName)
		{

			Destroy(this.gameObject);
			OnKeyPress_MoveGravity.speed = 18;
		}
	}
}