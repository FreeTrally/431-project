using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapElements : MonoBehaviour
{
    RaycastHit2D hit;

    public Transform firstElement = null;
    public Transform secondElement = null;
    public Transform tempElement;
    
    void Update()
    {
        hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (Input.GetMouseButtonDown(0) && hit)
        {
            if(!firstElement)  
            {
                firstElement = hit.transform;  
                tempElement = firstElement;

                Transform sky = firstElement.Find("Sky");
                sky.gameObject.SetActive(false);
                Transform skyHighlighted = firstElement.Find("SkyHighlighted");
                skyHighlighted.gameObject.SetActive(true);
            }
            else if(firstElement != null)  
            {
                secondElement = hit.transform;
                Swap();
            }
        }
    }

    public void Swap()
    {
        Transform sky = firstElement.Find("Sky");
        sky.gameObject.SetActive(true);
        Transform skyHighlighted = firstElement.Find("SkyHighlighted");
        skyHighlighted.gameObject.SetActive(false);
        
        firstElement.transform.position = secondElement.transform.position;
        secondElement.transform.position = tempElement.transform.position;
        
        firstElement = null;
        secondElement = null;
    }
}
