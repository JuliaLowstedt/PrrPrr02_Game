using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{


    public float jumpSpeed = 5;
    public Rigidbody2D rb;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundlayer;

    public float jumpForce;

    public string hoger = "";
    public string vanster = "";
    public string upp = "";
    public string ner = "";
    public float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        /*
       hoger = "d";
       vanster = "a";
       upp = "w";
       ner = "s";
        */
    }

    // Update is called once per frame
    void Update()
    {
        // Movement med piltangenterna. Detta "teleporterar" spelaren ett litet hack i varje riktning.
        if (Input.GetKey(vanster))
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(hoger))
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(upp))
        {

        }
        if (Input.GetKey(ner))
        {

        }

        if (Input.GetKey(upp))
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

