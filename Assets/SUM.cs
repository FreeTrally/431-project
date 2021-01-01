using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SUM : MonoBehaviour
{
    public Text SumText;
    public Text CellOne;
    public Text CellTwo;
    public Text CellThree;
    
    // Update is called once per frame
    void Update()
    {
        if (CellOne.text == "")
        {
            CellOne.text = "0";
            CellOne.enabled = false;
        }
        else if (CellOne.text != "" && CellOne.text != "0")
            CellOne.enabled = true;

        if (CellTwo.text == "")
        {
            CellTwo.text = "0";
            CellTwo.enabled = false;
        }
        else if (CellTwo.text != "" && CellTwo.text != "0")
            CellTwo.enabled = true;

        if (CellThree.text == "")
        {
            CellThree.text = "0";
            CellThree.enabled = false;
        }
        else if (CellThree.text != "" && CellThree.text != "0")
            CellThree.enabled = true;

        SumText.text = (double.Parse(CellOne.text) + 
            double.Parse(CellTwo.text) + 
            double.Parse(CellThree.text)).ToString();
    }
}
