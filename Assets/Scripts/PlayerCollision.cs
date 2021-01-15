using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject Camera;
    public GameObject PlayButton;

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        
        if (collisionInfo.collider.name == "Ground")
        {
            Debug.Log(collisionInfo.collider.name);
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("Target"))
        {
            var movement = this.GetComponent<PlayerMovement>();
            movement.Speed = 0;
            other.gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("Controller").GetComponent<EndGame>().TargetCounter++;
            PlayButton.SetActive(true);
        }
        else if (other.gameObject.CompareTag("Spikes"))
        {
            this.gameObject.SetActive(false);
            Camera.GetComponent<Pause>().Lose();
        }
        else if (other.gameObject.CompareTag("Jump"))
        {
            var movement = this.GetComponent<PlayerMovement>();
            movement.Jumping = true;
        }
    }
}
