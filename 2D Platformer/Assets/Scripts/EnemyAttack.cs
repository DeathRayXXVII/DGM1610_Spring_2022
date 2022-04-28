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
    public LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        levelManager = FindObjectOfType<LevelManager>();
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
        if(player.curHP <= 0)
        {
            levelManager.RespawnPlayer();
        }
    }
}
