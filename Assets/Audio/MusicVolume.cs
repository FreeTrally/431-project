using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSrc.volume = PlayerPrefs.GetFloat("musicVolume", 1f);
    }
}
