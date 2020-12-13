using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDPiece : MonoBehaviour
{
    public GameObject correctPlace;
    private bool moving;

    private float startPosX;
    private float startPosY;
    private float xLowerBorder = 0.923f;
    private float yLowerBorder = 0.742f;
    private float xUpperBorder = 5.479f;
    private float yUpperBorder = 4.777f;
    private float xPiecePos = 2.917f;
    private float yPiecePos = 2.496f;

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
        Vector3 objPos;
        objPos = this.gameObject.transform.position;
        moving = false;
        if (objPos.x >= xLowerBorder && objPos.x <= xUpperBorder
            && objPos.y >= yLowerBorder && objPos.y <= yUpperBorder)
        {
            this.gameObject.transform.position = new Vector3(xPiecePos, yPiecePos,
                this.gameObject.transform.localPosition.z);
        }
    }
}
