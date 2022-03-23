using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header ("Enemy Health")]
    public int curHP; //Health
    public int maxHp; //Max health

    [Header ("Enemy Attack")]
    public int damage;
    public float attackRange; //Range in which the player can attack
    public float attackRate;
    private float lastAttackTime;
    public PlayerControler player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerControler>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack();
        }
    }

    public void TakeDamge(int damage)
    {
        curHP -= damage;

        if(curHP<= 0)
        {
            die();
        }
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        player.TakeDamge(damage);
    }

    void die()
    {
        Destroy(gameObject);
    }
}
