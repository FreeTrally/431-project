using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTable : MonoBehaviour
{
    public GameObject table;
    public GameObject map;
   public void ShowHideTable()
    {
        if (table.gameObject.activeSelf)
        {
            table.SetActive(false);
            map.SetActive(true);
        }
        else if (!table.gameObject.activeSelf)
        {
            map.SetActive(false);
            table.SetActive(true);
        }
    }
}
