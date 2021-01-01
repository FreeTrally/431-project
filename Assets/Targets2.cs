using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Targets2 : Target
{
    public GameObject[] targets;
    int current = 0;
    
    public GameObject player;   

    void Start()
    {
        foreach (var e in targets)
        {
            e.SetActive(false);
        }
    }

    public override void PickTarget()
    {
        if (current < targets.Length)
            targets[current].SetActive(true);
        current++;
    }

    
}
