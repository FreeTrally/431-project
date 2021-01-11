using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSettings : MonoBehaviour
{
    private float masterVolume = 0.5f;
    private float audioVolume = 0.5f;
    private float musicVolume = 0.5f;

    void Start()
    {
        if (!PlayerPrefs.HasKey("audioVolume"))
            PlayerPrefs.SetFloat("audioVolume", audioVolume);
        if (!PlayerPrefs.HasKey("musicVolume"))
            PlayerPrefs.SetFloat("musicVolume", musicVolume);
    }

    public void SetAudioVolume(float v)
    {
        audioVolume = v;
        SetVolume();
    }
    public void SetMusicVolume(float v)
    {
        musicVolume = v;
        SetVolume();
    }

    public void SetMasterVolume(float v)
    {
        masterVolume = v;
        SetVolume();
    }

    private void SetVolume()
    {
        PlayerPrefs.SetFloat("audioVolume", audioVolume * masterVolume);
        PlayerPrefs.SetFloat("musicVolume", musicVolume * masterVolume);
        PlayerPrefs.Save();
    }
}
