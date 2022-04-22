using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [Header ("Enemy Attack")]
    public int damage;
    public float attackRange; //Range in which the player can attack
    public float attackRate;
    private float lastAttackTime;
    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        /* if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            OnTriggerEnter2D(Coollider2d other);
        }*/
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }
}
