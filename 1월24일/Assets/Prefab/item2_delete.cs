using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item2_delete : MonoBehaviour
{
	public string targetObjectName; // ��ǥ ������Ʈ �̸� : Inspector�� ����
    AudioSource audioSource;
    public AudioClip LoadSound;

    private void Start()
    {
        this.audioSource = this.gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = this.LoadSound;
        this.GetComponent<AudioSource>().loop = false;
    }

	void OnCollisionEnter2D(Collision2D collision)// �浹���� ��
	{
		// ���� �ڽ��� �����Ѵ� 
		if (collision.gameObject.name == targetObjectName)
		{
            this.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
			OnUpKeyPress_Throw.throwNum += 5;
		}
	}
}
