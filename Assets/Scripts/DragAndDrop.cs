using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject correctPlace;
    private bool moving;

    private float startPosX;
    private float startPosY;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 
                this.gameObject.transform.localPosition.z);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.position.x;
            startPosY = mousePos.y - this.transform.position.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;
    }
}
