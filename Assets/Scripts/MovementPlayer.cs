using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float speed, jumpForce, jumpCount;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 dr;
    
    private void Start()
    {
        jumpCount = 0;
    }

    private void Update()
    {
        Move();
    }

    private void LateUpdate()
    {
        rb.velocity = new Vector2(dr.x, rb.velocity.y);
    }

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        dr = Vector2.right * h * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpCount++;
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(dr.x, jumpForce);
        // rb.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse)
    }
}
