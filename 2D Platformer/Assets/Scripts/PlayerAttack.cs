using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header ("Player Attack")]
    public int damage;
    public float attackRange; //Range in which the player can attack
    public float attackRate;
    private float lastAttackTime;
    public EnemyPatrol1 enemy;
    public LayerMask enemyLayer;
    private Vector2 direction;
    public GameObject wepon;

    // Start is called before the first frame update
    void Start()
    {
        //enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyPatrol1>();
        //wepon = false;
        wepon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if(Input.GetKeyDown(KeyCode.R))
            {
                if(Time.time - lastAttackTime >= attackRate);
                //Attack();
                //wepon = true;
                Debug.Log("ATTACK");
            }
            else
            {
                //wepon = false;
            }*/
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        lastAttackTime = Time.time;
        enemy.TakeDamage(damage);
        
    }
    void Attack()
    {
        lastAttackTime = Time.time;
        //Raycast using the enemyLayer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);
        if(hit.collider != null)
        {
            hit.collider.GetComponent<EnemyPatrol1>()?.TakeDamage(damage);
            Debug.Log("you hit");
        }
    }
}
