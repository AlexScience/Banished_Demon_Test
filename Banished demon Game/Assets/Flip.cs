using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 10f;
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        walk();
        Jump();
        CheckingGround();
    }
    void walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
    }

    public float jumpForce = 7f;
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    public bool onGround;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;
    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
    }
}