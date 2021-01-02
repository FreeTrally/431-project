using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DnDButton : EventTrigger
{
    private bool startDragging;
    private Vector2 InitialPosition;

    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.position;
        Debug.Log(InitialPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (startDragging)
        {
            Vector2 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            transform.position = new Vector2(mousePos.x , mousePos.y);
        }
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        startDragging = true;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        startDragging = false;
        transform.position = InitialPosition;
    }
}
