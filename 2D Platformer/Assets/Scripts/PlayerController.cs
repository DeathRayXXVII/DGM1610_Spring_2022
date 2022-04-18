using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [header("Player Stats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    [header("Ground Check")]
    private bool isGrounded;//Are we able to jump 
    public Transfrom groundCheck; //Are we tuching the ground
    public float groundCheckRadius; //Making an area to cheak ground
    public LayerMask whatIsGround; //What is the ground
    private float moveVelocity;


    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponet<Rigidbody2D>();
    }
    void FixedUpdate() 
    {
        isGrounded = physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); // Ground check sensor


        moveVelocity = 0f; // Non-Stick Player
        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        rb.velocity = 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
}
