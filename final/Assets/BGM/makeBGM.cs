using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBGM : MonoBehaviour
{
    [Header("���� ���")]
    [SerializeField] Sound bgmSound;

    [Header("��� �÷��̾�")]
    [SerializeField] AudioSource bgmPlayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        bgmPlayer.clip = bgmSound.clip;
        bgmPlayer.Play();
    }
}
