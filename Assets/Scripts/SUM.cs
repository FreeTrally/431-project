using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class SUM : MonoBehaviour
{
    public Text SumText;
    public Text[] Cells;
    public GameObject Camera;

    public void Sum()
    {
        double sum = 0;
        var currentCulture = System.Globalization.CultureInfo.InstalledUICulture;
        var numberFormat = (System.Globalization.NumberFormatInfo)currentCulture.NumberFormat.Clone();
        numberFormat.NumberDecimalSeparator = ".";
        foreach (var e in Cells)
        {
            if (e.text == "")
            {
                e.text = "0";
                e.enabled = false;
            }
            else if (e.text != "" && e.text != "0")
                e.enabled = true;

            //sum += e.GetComponent<TargetScript>().GetCurrentValue();
            var value = 0.0;
            var mulitplier = e.GetComponentInParent<Cell>().multiplier;
            if(double.TryParse(e.text, System.Globalization.NumberStyles.Any, numberFormat, out value))
                sum += value * mulitplier;
        }

        // SumText.text = (sum).ToString();
        SumText.text = Convert.ToString(sum);
      
        if (sum == 1 || SumText.text.Equals("1"))
        {
            Debug.Log(sum);
            Camera.GetComponent<Pause>().WinForNormies();
            //SceneManager.LoadScene("(CR)Menu");
        }
    }
}
