using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTable : MonoBehaviour
{
    public GameObject Table;
    public GameObject Inv;

    public void ShowHideTable()
    {
        if (Table.gameObject.activeSelf)
        {
            Table.SetActive(false);
        }
        else if (!Table.gameObject.activeSelf)
        {
            Table.SetActive(true);
        }

        if (Inv.gameObject.activeSelf)
        {
            Inv.SetActive(false);
        }
        else if (!Inv.gameObject.activeSelf)
        {
            Inv.SetActive(true);
        }
    }
}
