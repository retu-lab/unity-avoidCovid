using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class item2_delete : MonoBehaviour
{
	public string targetObjectName; // ��ǥ ������Ʈ �̸� : Inspector�� ����
    public static AudioClip loadSound;
    static AudioSource audioSrc;

    int a = 0;

    void Start()
    {
        loadSound = Resources.Load<AudioClip>("load");
        audioSrc = GetComponent<AudioSource>();
    }

	void OnCollisionEnter2D(Collision2D collision)// �浹���� ��
	{
		// ���� �ڽ��� �����Ѵ� 
		if (collision.gameObject.name == targetObjectName)
		{

            audioSrc.PlayOneShot(loadSound);
            //audioSrc.Play();
            //this.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
			OnUpKeyPress_Throw.throwNum += 5;
		}
	}


}
