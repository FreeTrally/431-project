using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolume : MonoBehaviour
{
    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();  
    }

    private void Update()
    {
        audioSrc.volume = PlayerPrefs.GetFloat("audioVolume", 1f);
    }
}
