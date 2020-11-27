using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo) {
        
        if (collisionInfo.collider.name == "Ground")
        {
            Debug.Log(collisionInfo.collider.name);
        }
    }
}
