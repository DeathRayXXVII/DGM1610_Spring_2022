using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    [Header("Ground Check")]
    private bool isGrounded;//Are we able to jump 
    public Transform groundCheck; //Are we tuching the ground
    public float groundCheckRadius; //Making an area to cheak ground
    public LayerMask whatIsGround; //What is the ground
    private float moveVelocity;


    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate() 
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround); // Ground check sensor

        moveVelocity = 0f; // Non-Stick Player
        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        rb.velocity = new Vector2(moveVelocity, rb.velocity.y); //Helps move the player left/Right
        
        if(Input.GetKey(KeyCode.Space) && isGrounded) //Removed GetKeyDown
                {
                    Jump();
                }
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    }
}
