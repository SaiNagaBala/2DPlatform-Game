using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    public float jumpForce;
    Rigidbody2D rb;
    bool isGrounded;
    float xInput, yInput;
    bool isFacingRight;
    public LayerMask layer;
    public Transform groundCheck;
    public float checkRadius;

    void Start()
    {
        isFacingRight = true;  
    }
    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, layer);
        xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput*playerSpeed,rb.velocity.y);
        if(isFacingRight==false && xInput>0)
        {
            Flip();
        }
        else if(isFacingRight==true && xInput<0)
        {
            Flip();
        }
        if(Input.GetButtonDown("Fire1") && isGrounded==true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0, 180, 0);
    }
    public void SuperJump()
    {
        rb.velocity=Vector2.up * jumpForce*2.0f;
    }
}
