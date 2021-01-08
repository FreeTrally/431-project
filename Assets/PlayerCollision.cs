using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject Table;
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
            var movement = this.GetComponent<PlayerMovement>();
            movement.Speed = 0;
            other.gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("Controller").GetComponent<EndGame>().TargetCounter++;
        }
        else if (other.gameObject.CompareTag("Spikes"))
        {
            this.gameObject.SetActive(false);
            //gameObject.SetActive(false);
            //Table.SetActive(true);
            //RestartButton.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Jump"))
        {
            //other.gameObject.SetActive(false);
            var movement = this.GetComponent<PlayerMovement>();
            movement.Jumping = true;
        }
    }
}
