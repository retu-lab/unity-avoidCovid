using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBGM : MonoBehaviour
{
    [Header("사운드 등록")]
    [SerializeField] Sound bgmSound;

    [Header("브금 플레이어")]
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
