using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SUM : MonoBehaviour
{
    public Text SumText;
    public Text[] Cells;
    
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
            SceneManager.LoadScene("(CR)Menu");
        }
    }

    IEnumerator ToMenu()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        SceneManager.LoadScene("(CR)Menu");
    }
}
