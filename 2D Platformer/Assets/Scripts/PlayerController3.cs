using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    [Header("Player Stats")]
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    public int curHP; //Health
    public int maxHp; //Max health
    public HealthBar2 healthBar; //visual health
    private Vector2 direction;

    [Header ("Player Combat")]
    public int damage; //Damage
    public float attackRange; //Range in which the player can attack
    public float attackRate; //Rate you can attack
    private float lastAttackTime;
    public LayerMask enemyLayer;
    public PlayerAttack playerAttack;
    public GameObject wepon;// weopn of use

    [Header ("Inventory")]
    public int key; //How many keys are in inventory
    //public int coins;
    public int HealthPotion; //How many health potions are in inventory

    [Header("Ground Check")]
    private bool isGrounded;//Are we able to jump 
    public Transform groundCheck; //Are we tuching the ground
    public float groundCheckRadius; //Making an area to cheak ground
    public LayerMask whatIsGround; //What is the ground
    private float moveVelocity;
    [Header("Audio")]
    private AudioSource source; //Audio sourece
    public AudioClip marker; //Audio clip
    private AudioSource sourceAttack; //Audio sourece
    public AudioClip attackMarker; //Audio cli


    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
        curHP = maxHp;
        healthBar.SetHealth(maxHp); //Updates the health bar
        source = GetComponent<AudioSource>(); //Getting the audio source
        sourceAttack = GetComponent<AudioSource>();
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
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
                {
                    Jump();
                }
        
        if(Time.time - lastAttackTime >= attackRate)
        {
                if(Input.GetMouseButtonDown(0))
                {
                    wepon.SetActive(true);
                    Attack();
                    Debug.Log("ATTACK"); 
                }      
        }
        if (Input.GetMouseButtonUp(0))
        {
            wepon.SetActive(false);
        }
        
        //Player Flip
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if(GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        source.PlayOneShot(marker,1.0f);//Play the Audio source on jump
    }
    
    void Attack()
    {
        lastAttackTime = Time.time;
        sourceAttack.PlayOneShot(attackMarker,1.0f);//Play the Audio source on attack
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
