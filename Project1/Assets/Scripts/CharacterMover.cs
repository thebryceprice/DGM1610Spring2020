using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpForce = 10f;
    private int jumpCount = 0;
    public int jumpCountMax = 5;
    
    [SerializeField] private Text currentJumpText;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }
        
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }
        
        positionDirection.y -= gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }

    public void FixedUpdate()
    {
        currentJumpText.text = jumpCount.ToString("0");
    }
}