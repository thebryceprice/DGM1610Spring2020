using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float moveInput;
    
    private Rigidbody rb;
    public bool isGrounded;
    public float jumpSpeed;

    private bool facingRight = true;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //INDICATING WHAT IS CONSIDERED THE GROUND
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
    }

    private void FixedUpdate()
    {
        //SINGLE JUMP CODE
        if ((Input.GetKeyDown(KeyCode.Space)) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 2, 0) * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }
        
        
        //HORZINTAL MOVEMENT WITH SPRITE FLIP
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    //FLIP TRANSFORMATION RULES
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
