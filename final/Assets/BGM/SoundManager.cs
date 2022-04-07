using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound{
    public string soundName;
    public AudioClip clip;
}

public class SoundManager : MonoBehaviour
{
    [Header("사운드 등록")]
    [SerializeField] Sound[] bgmSounds;

    [Header("브금 플레이어")]
    [SerializeField] AudioSource bgmPlayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayRandomBGM(0);
    }

    public void PlayRandomBGM(int a)
    {
        //int random = Random.Range(0, 3);
        bgmPlayer.clip = bgmSounds[a].clip;
        bgmPlayer.Play();
    }
}
