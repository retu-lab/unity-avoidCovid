using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class item2_delete : MonoBehaviour
{
	public string targetObjectName; // 목표 오브젝트 이름 : Inspector에 지정
    public static AudioClip loadSound;
    static AudioSource audioSrc;

    int a = 0;

    void Start()
    {
        loadSound = Resources.Load<AudioClip>("load");
        audioSrc = GetComponent<AudioSource>();
    }

	void OnCollisionEnter2D(Collision2D collision)// 충돌했을 때
	{
		// 상대와 자신을 삭제한다 
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
