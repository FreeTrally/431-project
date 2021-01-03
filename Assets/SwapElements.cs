using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapElements : MonoBehaviour
{
    public GameObject player;

    public GameObject PlayButton;   //костыль чтобы не кликались элементы до нажатия кнопки
    public Transform firstElement = null;
    public Transform secondElement = null;
    Vector3 tempPosition;

    void Update()
    {
        player = GameObject.Find("Player");
        if (PlayButton.activeInHierarchy)
            {
            LayerMask element = LayerMask.GetMask("Element");
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);                
            RaycastHit2D selectHit = Physics2D.Raycast(new Vector2(worldPosition.x, worldPosition.y), Vector2.zero, element);

            if (selectHit && Input.GetMouseButtonDown(0))
            {
                
                if (firstElement == null && 
                    selectHit.transform.name != "Ground" && 
                    !Physics2D.IsTouching(selectHit.collider, player.GetComponent<Collider2D>()))
                {
                    firstElement = selectHit.transform;

                    Transform sky = firstElement.Find("Sky");
                    sky.gameObject.SetActive(false);
                    Transform skyHighlighted = firstElement.Find("SkyHighlighted");
                    skyHighlighted.gameObject.SetActive(true);
                }
                else if (firstElement != null && 
                    selectHit.transform.name != "Ground" &&
                    !Physics2D.IsTouching(selectHit.collider, player.GetComponent<Collider2D>()))
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

        tempPosition = firstElement.transform.position;
        firstElement.transform.position = secondElement.transform.position;
        secondElement.transform.position = tempPosition;

        firstElement = null;
    }
}
