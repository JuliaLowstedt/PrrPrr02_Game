using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoraPlayerScript : PlayerScript 
{
    public float jumpSpeed = 5;
    public Rigidbody2D rb;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundlayer;

    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
        vanster = "a";
        hoger = "d";
        upp = "w";
        ner = "s";
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (isGrounded)
            {
                Jump();
            }

        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }
    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}

