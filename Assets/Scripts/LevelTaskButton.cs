﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTaskButton : MonoBehaviour
{
    public GameObject world;
    public GameObject taskPanel;
    public GameObject pauseButton;

    public void OpenClose()
    {
        world.SetActive(!world.active);
        taskPanel.SetActive(!taskPanel.active);
        pauseButton.SetActive(!pauseButton.active);
    }
}
