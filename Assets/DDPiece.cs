using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDPiece : MonoBehaviour
{
    public Slot[] slots;
    private bool moving;
    private float startPosX;
    private float startPosY;
    

    public class Slot
    {
        public float xLowerBorder;
        public float yLowerBorder;
        public float xUpperBorder;
        public float yUpperBorder;
        public float xPiecePos;
        public float yPiecePos;
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
        Vector3 objPos;
        objPos = this.gameObject.transform.position;
        moving = false;
        foreach (var e in slots)
        {
            if (objPos.x >= e.xLowerBorder && objPos.x <= e.xUpperBorder
            && objPos.y >= e.yLowerBorder && objPos.y <= e.yUpperBorder)
            {
                this.gameObject.transform.position = new Vector3(e.xPiecePos, e.yPiecePos,
                    this.gameObject.transform.localPosition.z);
                break;
            }
            else
            {
                this.gameObject.transform.position = new Vector3(objPos.x, objPos.y,
                    this.gameObject.transform.localPosition.z);
            }
        }      
    }
}
