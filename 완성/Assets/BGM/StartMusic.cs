using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backmusic;

    void Awake()
    {
        BackgroundMusic = GameObject.Find("BackgroundMusic");
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //������� �����ص�
        if (backmusic.isPlaying) return; //��������� ����ǰ� �ִٸ� �н�
        else
        {
            backmusic.Play();
            DontDestroyOnLoad(BackgroundMusic); //������� ��� ����ϰ�(���� ��ư�Ŵ������� ����)
        }
    }
}