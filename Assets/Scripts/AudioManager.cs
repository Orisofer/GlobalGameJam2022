using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource[] soundEffects;

    public AudioSource[] gameMusic;

    public float volumeDown;
    public float originalVolume = 1f;


    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        originalVolume = gameMusic[0].volume;
    }

    public void PlaySFX(int soundToPlay)
    {
        soundEffects[soundToPlay].Stop();

        soundEffects[soundToPlay].Play();
    }

    public void PlayMusic(int soundToPlay)
    {
        gameMusic[soundToPlay].Play();
    }

    public void StopMusic(int soundToPlay)
    {
        gameMusic[soundToPlay].Stop();
    }

    public void TurnDownVolume(int soundToTurnVolDown)
    {
        gameMusic[soundToTurnVolDown].volume -= volumeDown;
    }
}
