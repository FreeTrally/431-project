using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed = 5f;
    public bool MoveRight;

    public Transform WallCheck;
    public float WallCheckRadius;
    public LayerMask WhatIsWhall;
    private bool hittingWall;

    void Update()
    {
        hittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWhall);

        if(hittingWall)
        {
            MoveRight = !MoveRight;
        }

        

        if(MoveRight)
        {
            Vector3 movement = new Vector3(1f, 0f, 0f);
            transform.position += movement * Time.deltaTime * Speed;
        }
        else
        {
            Vector3 movement = new Vector3(-1f, 0f, 0f);
            transform.position += movement * Time.deltaTime * Speed;
        }
    }
}
