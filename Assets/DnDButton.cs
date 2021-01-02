using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DnDButton : EventTrigger
{
    public Button tablePlace;
    public Text PieceText;
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
        var place = tablePlace.GetComponent<RectTransform>();
        var crnrs = new Vector3[4];
        place.GetComponent<RectTransform>().GetWorldCorners(crnrs);
        var pos = place.position;
        Vector2 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        if (mousePos.x >= crnrs[0].x && mousePos.x <= crnrs[1].x 
            && mousePos.y >= crnrs[0].y && mousePos.y <= crnrs[1].y)
        {
            transform.position = pos;
            tablePlace.GetComponent<Text>().text = PieceText.text;
        }
        else 
            transform.position = InitialPosition;
    }
}
