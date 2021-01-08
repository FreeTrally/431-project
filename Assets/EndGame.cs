using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public int TargetCounter;
    private int targets;
    public GameObject Table;
    public GameObject Inventory;
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target").Length;
    }

    private void Update()
    {
        if (TargetCounter == targets)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            TargetCounter = -1;
            player.SetActive(false);
            Table.SetActive(true);
            Inventory.SetActive(true);
        }
    }
}
