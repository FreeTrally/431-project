using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public Sprite on, off;
    private Image image;
    private bool muted = false;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void MuteOnOff()
    {
        if(!muted)
        {
            AudioListener.volume = 0;
            image.sprite = off;
        }
        else
        {
            AudioListener.volume = PlayerPrefs.GetFloat("volume");
            image.sprite = on;
        }
        muted = !muted;
    }
}
