using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item2_delete : MonoBehaviour
{
	public string targetObjectName; // 목표 오브젝트 이름 : Inspector에 지정
    AudioSource audio;
    public AudioClip LoadSound;

    int a = 0;

    void Start()
    {
        audio= gameObject.AddComponent<AudioSource>();
        this.GetComponent<AudioSource>().clip = LoadSound;
        this.GetComponent<AudioSource>().loop = false;
    }

	void OnCollisionEnter2D(Collision2D collision)// 충돌했을 때
	{
		// 상대와 자신을 삭제한다 
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
