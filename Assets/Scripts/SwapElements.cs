using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapElements : MonoBehaviour
{
    public GameObject player;

    public GameObject PlayButton;   //костыль чтобы не кликались элементы до нажатия кнопки
    public Transform firstElement = null;
    public Transform secondElement = null;
    public int delta;
    Vector3 tempPosition;

    void Update()
    {
        player = GameObject.Find("Player");
        if (PlayButton.activeInHierarchy)
        {
            LayerMask element = LayerMask.GetMask("Element");
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D selectHit = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, element);

            if (selectHit && Input.GetMouseButtonDown(0) && selectHit.transform.name.Substring(0, 5) == "Block")
            {
                if (firstElement == null)
                {
                    firstElement = selectHit.transform;
                    if (firstElement.Find("Blocked") != null)
                        return;
                    Transform sky = firstElement.Find("Sky");
                    sky.gameObject.SetActive(false);
                    Transform skyHighlighted = firstElement.Find("SkyHighlighted");
                    skyHighlighted.gameObject.SetActive(true);
                }
                else
                {
                    secondElement = selectHit.transform;
                    Swap();
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

        if (firstElement.Find("Blocked") == null && secondElement.Find("Blocked") == null)
        {
            if (firstElement.Find("HorB") != null || secondElement.Find("HorB") != null)
            {
                if (Math.Abs(firstElement.transform.position.x - secondElement.transform.position.x) <= delta)
                    TrueSwap();
            }
            else if (firstElement.Find("VerB") != null || secondElement.Find("VerB") != null)
            {
                if (Math.Abs(firstElement.transform.position.y - secondElement.transform.position.y) <= delta)
                    TrueSwap();
            }
            else
                TrueSwap();
        }

        firstElement = null;
        secondElement = null;
    }

    private void TrueSwap()
    {
        tempPosition = firstElement.transform.position;
        firstElement.transform.position = secondElement.transform.position;
        secondElement.transform.position = tempPosition;
    }
}