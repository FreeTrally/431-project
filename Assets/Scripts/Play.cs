﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public GameObject Player;

    public void StartPlayer()
    {
        Player.GetComponent<PlayerMovement>().enabled = true;
    }
}