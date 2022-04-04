using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP; //Health
    public int maxHp; //Max health
    public HealthBar healthBar; //visual health

    [Header ("Player Movement")]
    public float moveSpeed = 5f; //Speed for the player to move
    private Rigidbody2D rb; //Store the referenced 2D rigidbody
    private Vector2 movement; //Store the players x,y position movement
    private Vector2 direction; 

    [Header ("Player Combat")]
    public int damage; //Damage
    public float attackRange; //Range in which the player can attack
    public float attackRate; //Rate you can attack
    private float lastAttackTime;
    public LayerMask enemyLayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        curHP == maxHp;
        healthBar.SetHealth(maxHp);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //Input for left right movement
        movement.y = Input.GetAxis("Vertical"); //Input for updown movment

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time - lastAttackTime >= attackRate)
                Attack();
        }
            
        


    }
    //Set number of calls per frame
    void FixedUpdate() 
    {
        // Apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
        updateDirection();
    }
    void updateDirection()
    {
        Vector2 vel = new Vector2(movement.x, movement.y);
        if (vel.magnitude != 0)
        {
            direction = vel;
        }
        rb.velocity = vel * moveSpeed;
    }
    void Attack()
    {
        lastAttackTime = Time.time;
        //Raycast using the enemyLayer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);
        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>().TakeDamge(damage);
        }
    }
    public void TakeDamge(int damage)
    {
        curHP -= damage;

        if(curHP <= 0)
        {
            die();
        }
    }

    void die()
    {
        Debug.Log("!!Player has Died!!"); 
    }
}
