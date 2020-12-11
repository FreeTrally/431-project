using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapElements : MonoBehaviour
{
    RaycastHit2D selectHit;

    public GameObject PlayButton;   //костыль чтобы не кликались элементы до нажатия кнопки
    public Transform firstElement = null;
    public Transform secondElement = null;
    Vector3 tempPosition;

    void Update()
    {
        if (!PlayButton.activeInHierarchy)
            {
            if (Input.GetMouseButtonDown(0))    
            {
                RaycastHit2D selectHit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (selectHit)
                {
                    if (firstElement == null)
                    {
                        firstElement = selectHit.transform;

                        Transform sky = firstElement.Find("Sky");
                        sky.gameObject.SetActive(false);
                        Transform skyHighlighted = firstElement.Find("SkyHighlighted");
                        skyHighlighted.gameObject.SetActive(true);
                    }
                    else if (firstElement != null)
                    {
                        secondElement = selectHit.transform;
                        Swap();
                    }
                }
            }
        }
    }

    public void Swap()
    {
        Transform sky = firstElement.Find("Sky");
        sky.gameObject.SetActive(true);
        Transform skyHighlighted = firstElement.Find("SkyHighlighted");
        skyHighlighted.gameObject.SetActive(false);

        tempPosition = firstElement.transform.position;
        firstElement.transform.position = secondElement.transform.position;
        secondElement.transform.position = tempPosition;

        firstElement = null;
        //secondElement = null;
        //tempPosition = new Vector3();
    }
}
