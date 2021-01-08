using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
    public bool MoveRight;
    public bool Jumping = false;

    public Transform WallCheck;
    public float WallCheckRadius;
    public LayerMask WhatIsWhall;
    private bool hittingWall;
    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        hittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWhall);

        if (hittingWall)
        {
            MoveRight = !MoveRight;
        }

        if (Jumping)
        {
            transform.position += new Vector3(0f, 5.5f, 0f);
            Jumping = !Jumping;
        }
        else if (MoveRight)
        {
            Vector3 movement = new Vector3(1f, 0f, 0f);
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.position += movement * Time.deltaTime * Speed;
        }
        else
        {
            Vector3 movement = new Vector3(-1f, 0f, 0f);
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.position += movement * Time.deltaTime * Speed;
        }
    }

    public void SetSpeed()
    {
        Speed = 5f;
    }
}
