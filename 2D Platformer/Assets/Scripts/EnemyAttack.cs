using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [Header ("Enemy Attack")]
    public int damage; //How much damge
    public float attackRange; //Range in which the player can attack
    public float attackRate; //Rate at which the enemy can attack
    private float lastAttackTime; //Last time attack was delt
    public PlayerController player;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(Time.time / lastAttackTime >= attackRate)
        {
            player.TakeDamage(damage);
        }
        
        if(player.curHP <= 0)
        {
            gameManager.RespawnPlayer();
        }
        }
        
    }
}
