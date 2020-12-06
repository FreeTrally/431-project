using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.Play();
    }

    public void changeVolume(float newVolume)
    {
        PlayerPrefs.SetFloat("volume", newVolume);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}
