using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject TargetOne;
    public GameObject TargetTwo;
    public GameObject TargetThree;
    public GameObject TargetFour;
    public GameObject TargetFive;
    public GameObject Inventory;
    int TargetCollectedCounter;
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        
        if (collisionInfo.collider.name == "Ground")
        {
            Debug.Log(collisionInfo.collider.name);
        }
    }

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other) 
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Target"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Spikes"))
        {
            Destroy(gameObject);
        }
    }
}
