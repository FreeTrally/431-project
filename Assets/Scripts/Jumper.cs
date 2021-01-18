using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public Sprite sprite;

    private bool done = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Equals("Player"))
        if(!done)
        {
            GetComponent<SpriteRenderer>().sprite = sprite;
            GetComponent<BoxCollider2D>().enabled = false;
            done = true;
        }
    }
}
