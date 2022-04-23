using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol1 : MonoBehaviour
{
    [Header ("Enemy Stats")]
    public int curHP; //Health
    public int maxHp; //Max health
    public EnemyHealth enemyHealth; //visual health


    public float speed; //Speed
    public float distance;
    private bool moveRight = true;
    public Transform groundDetection;
    public PlayerController player;

    [Header ("Loot Drop")]
    public GameObject lootDrop;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        curHP = maxHp;
        enemyHealth.SetHealth(maxHp); //Updates the health bar
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //Move the enemy Right
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down,  distance);

        if(groundInfo.collider == false) // Checking the direction of movement
        {
            if(moveRight == true)
            {
                transform.eulerAngles = new Vector3(0,-180,0); //Flip enemy at edge to move Left
                moveRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0,0,0); //Flip enemy at edge to move right
                moveRight = true;
            }
        }
    }
    public void TakeDamage(int damage)
    {
        curHP -= damage;
        enemyHealth.SetHealth(curHP);
        Debug.Log("I got hit");
        if(curHP <= 0)
        {
            die();
            LootDrop();
        }
    }
    void die()
    {
        Destroy(gameObject);
    }
    void LootDrop()
    {
        Instantiate(lootDrop, transform.position,  Quaternion.identity);
    }
}
