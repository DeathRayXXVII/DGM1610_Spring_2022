using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP; //Health
    public int maxHp; //Max health
    [Header ("Player Movement")]
    public float moveSpeed = 5f; //Speed for the player to move
    private Rigidbody2D rb; //Store the referenced 2D rigidbody
    Vector2 movement; //Store the players x,y position movement
    [Header ("Player Combat")]
    public float attackRange; //Range in with the player can attack
    public float attackRate; //Rate you can attack
    private float lastAttackTime;
    public int damage; //Damage
    public LayerMask enemyLayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //Input for left right movement
        movement.y = Input.GetAxis("Vertical"); //Input for updown movment


    }
    //Set number of calls per frame
    private void FixedUpdate() 
    {
        // Apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        //Raycast using the enemyLayer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, facingDirection, attackRange, enemyLayer);
        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>().TakeDamgae(damage);
        }
    }

    void die()
    {
        Debug.Log("!!Player has Died!!"); 
    }
}
