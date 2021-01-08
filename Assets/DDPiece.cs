using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DDPiece : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Button[] tablePlaces;
    public Text[] tablePlacesTexts;
    public Text PieceText;
    private bool startDragging;
    private Vector2 InitialPosition;

    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (startDragging)
        {
            Vector2 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            transform.position = new Vector2(mousePos.x, mousePos.y);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        startDragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        startDragging = false;
        Vector2 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        for (var i = 0; i < tablePlaces.Length; i++)
        {
            var place = tablePlaces[i].GetComponent<RectTransform>();
            var crnrs = new Vector3[4];
            place.GetComponent<RectTransform>().GetWorldCorners(crnrs);
            var pos = place.position;

            if (mousePos.x >= crnrs[0].x && mousePos.x <= crnrs[2].x
                && mousePos.y >= crnrs[0].y && mousePos.y <= crnrs[2].y)
            {
                tablePlacesTexts[i].text = PieceText.text;
                transform.position = tablePlaces[i].transform.position;
                //transform.position = InitialPosition;
            }
        }
        //var place = tablePlace.GetComponent<RectTransform>();
        //var crnrs = new Vector3[4];
        //place.GetComponent<RectTransform>().GetWorldCorners(crnrs);
        //var pos = place.position;
        
        //if (mousePos.x >= crnrs[0].x && mousePos.x <= crnrs[2].x
        //    && mousePos.y >= crnrs[0].y && mousePos.y <= crnrs[2].y)
        //{
        //    tablePlaceText.text = PieceText.text;          
        //    transform.position = tablePlace.transform.position;
        //    //transform.position = InitialPosition;
        //}
        //else
        //    transform.position = InitialPosition;
    }
}