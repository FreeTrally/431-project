using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTable : MonoBehaviour
{
    public GameObject table;
   public void ShowHideTable()
    {
        if (table.gameObject.activeSelf)
        {
            table.SetActive(false);
        }
        else if (!table.gameObject.activeSelf)
        {
            table.SetActive(true);
        }
    }
}
