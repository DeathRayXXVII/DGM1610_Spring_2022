using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    public int curHP; //Health
    public int maxHp; //Max health
    public HealthBar healthBar; //visual health

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
        curHP = maxHp;
        healthBar.SetHealth(maxHp); //Updates the health bar
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
        
        
    }
    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) //Removed GetKeyDown
                {
                    Jump();
                }
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    }
    public void TakeDamage(int Damage)
    {
        curHP -= Damage;
        healthBar.SetHealth(curHP);
        
        if(curHP <= 0)
        {
            die();
        }
    }

    private void die() 
    {
        {
            Debug.Log("!!Player has Died!!");
        }
    }
}
