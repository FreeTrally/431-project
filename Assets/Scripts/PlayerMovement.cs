using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
    public bool MoveRight;
    public bool Jumping = false;
    public float JumpF = 5.5f;

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
            rigidBody.position += new Vector2(0f, JumpF);
            Jumping = !Jumping;
            MoveRight = !MoveRight;
        }
        else if (MoveRight)
        {
            var movement = new Vector2(1f, 0f);
            transform.eulerAngles = new Vector2(0, 0);
            rigidBody.position += movement * Time.deltaTime * Speed;
        }
        else
        {
            var movement = new Vector2(-1f, 0f);
            transform.eulerAngles = new Vector2(0, 180);
            rigidBody.position += movement * Time.deltaTime * Speed;
        }
    }

    public void SetSpeed(float value)
    {
        Speed = value;
    }
}
