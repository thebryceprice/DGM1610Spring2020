using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float moveHorizontal;
    private float moveVertical;

    public float jumpStrength = 10;
    public LayerMask groundLayer;
    public BoxCollider bC;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bC = GetComponent<BoxCollider>();
    }
    
    //LEFT RIGHT MOVEMENT (VERTICAL REMOVED FOR NOW)
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        //moveVertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(moveHorizontal, 0);
        // move up    moveVertical * 10);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*jumpStrength, ForceMode.Impulse);
        }
    }
}
