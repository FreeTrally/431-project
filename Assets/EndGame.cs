using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public int TargetCounter;
    public int Targets;
    void Start()
    {
        Targets = GameObject.FindGameObjectsWithTag("Target").Length;
    }

    private void Update()
    {
        if (TargetCounter == Targets)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.SetActive(false);
        }
    }
}
