using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item2_delete : MonoBehaviour
{
	public string targetObjectName; // ��ǥ ������Ʈ �̸� : Inspector�� ����
    AudioSource audio;
    public AudioClip LoadSound;

    int a = 0;

    void Start()
    {
        audio= gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = LoadSound;
        this.GetComponent<AudioSource>().loop = false;
    }

	void OnCollisionEnter2D(Collision2D collision)// �浹���� ��
	{
		// ���� �ڽ��� �����Ѵ� 
		if (collision.gameObject.name == targetObjectName)
		{
            this.audio.Play();
            audio.PlayOneShot(LoadSound, 1f);
            GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
			OnUpKeyPress_Throw.throwNum += 5;
		}
	}


}
