using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public int jumpCount = 0;
    public int maxJumps = 2;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;

    public bool isGrounded;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, WhatIsGround);

        rb.velocity = new Vector2(speed * Input.GetAxis("Horizontal"), rb.velocity.y);

        if (Physics2D.Raycast(transform.position, -Vector2.up, gameObject.GetComponent<Collider2D>().bounds.size.y / 2 + 0.1f, WhatIsGround))
        {
            isGrounded = true;
            jumpCount = 2;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetKeyDown(jump) && jumpCount < maxJumps) 
        {
            jumpCount++;
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
