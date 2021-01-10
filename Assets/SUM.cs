using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SUM : MonoBehaviour
{
    public Text SumText;
    public Text[] Cells;
    public GameObject EndGameScreen;

    // Update is called once per frame
    void Update()
    {
        double sum = 0;
        foreach (var e in Cells)
        {
            if (e.text == "")
            {
                e.text = "0";
                e.enabled = false;
            }
            else if (e.text != "" && e.text != "0")
                e.enabled = true;
            sum += double.Parse(e.text);
        }

        SumText.text = (sum).ToString();
      
        if (SumText.text.Equals("1"))
        {
            Debug.Log(sum);
            EndGameScreen.SetActive(true);
            //SceneManager.LoadScene("(CR)Menu");
        }
    }
}
