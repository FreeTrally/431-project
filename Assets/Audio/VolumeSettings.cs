using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSettings : MonoBehaviour
{
    private float masterVolume = 1f;
    private float audioVolume = 1f;
    private float musicVolume = 1f;

    void Start()
    {
        if (!PlayerPrefs.HasKey("audioVolume"))
            PlayerPrefs.SetFloat("audioVolume", audioVolume);
        if (!PlayerPrefs.HasKey("musicVolume"))
            PlayerPrefs.SetFloat("musicVolume", musicVolume);
    }

    public void SetAudioVolume(float v)
    {
        audioVolume = v * masterVolume;
        SetVolume();
    }
    public void SetMusicVolume(float v)
    {
        musicVolume = v * masterVolume;
        SetVolume();
    }

    public void SetMasterVolume(float v)
    {
        masterVolume = v;
        audioVolume *= masterVolume;
        musicVolume *= masterVolume;
        SetVolume();
    }

    private void SetVolume()
    {
        PlayerPrefs.SetFloat("audioVolume", audioVolume);
        PlayerPrefs.SetFloat("musicVolume", musicVolume);
        PlayerPrefs.Save();
    }
}
