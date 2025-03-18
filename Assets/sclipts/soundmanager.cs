using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    private static soundmanager instance;
    public static soundmanager Instance
    {
        get
        {
            instance = (soundmanager)FindAnyObjectByType(typeof(soundmanager));
            if (instance == null)
            {
                GameObject obj = new GameObject("SoundManager", typeof(soundmanager));
                instance = obj.GetComponent<soundmanager>();
            }

            return instance;
        }
    }

    public AudioSource bgmPlayer;
    public AudioSource sfxPlayer;

    public AudioClip bgmClip;
    public AudioClip jumpClip;
    public AudioClip coinClip;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        PlayBGM();
    }

    public void PlayBGM()
    {
        bgmPlayer.clip = bgmClip;
        bgmPlayer.Play();
    }

    public void PlaySFX(string sfxName)
    {
        if (sfxName == "jump")
        {
            sfxPlayer.PlayOneShot(jumpClip);
        }

        if(sfxName == "coin")
        {
            sfxPlayer.PlayOneShot(coinClip);
        }
    }
}
