using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

        var sum = double.Parse(CellOne.text) +
            double.Parse(CellTwo.text) +
            double.Parse(CellThree.text);
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
