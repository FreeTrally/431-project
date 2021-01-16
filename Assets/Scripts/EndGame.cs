using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public int TargetCounter;
    public GameObject[] LvlTargets;
    private int openedTargets = 0;
    private int targetsCount;

    void Start()
    {
        targetsCount = GameObject.FindGameObjectsWithTag("Target").Length;
        foreach (var e in LvlTargets)
            e.SetActive(false);
    }

    private void Update()
    {
        if (openedTargets < TargetCounter 
            && openedTargets < LvlTargets.Length)
        {
            LvlTargets[openedTargets].SetActive(true);
            openedTargets++;
        }

        if (TargetCounter == targetsCount)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            TargetCounter = -1;
            //player.SetActive(false);
            //Table.SetActive(true);
            //Inventory.SetActive(true);
        }
    }
}
