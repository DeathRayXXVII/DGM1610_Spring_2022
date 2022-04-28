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
    //public EnemyController enemy;
    public LayerMask enemyLayer;
    private Vector2 direction;
    public GameObject wepon;

    // Start is called before the first frame update
    void Start()
    {
        
        //wepon = false;
        wepon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyController>();
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
        //enemy.TakeDamage(damage);
        Attack();
        
    }
    void Attack()
    {
        lastAttackTime = Time.time;
        //Raycast using the enemyLayer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);
        if(hit.collider != null)
        {
            hit.collider.GetComponent<EnemyController>()?.TakeDamage(damage);
            Debug.Log("you hit");
        }
    }
}
