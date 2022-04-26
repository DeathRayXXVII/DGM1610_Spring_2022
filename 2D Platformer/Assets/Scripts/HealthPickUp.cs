using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    public HealthBar healthBar;
    public PlayerController player;
    public int healthToGive;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        healthBar = GameObject.Find("HealthBar_UI").GetComponent<HealthBar>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        
        if (player.curHP >= player.maxHp)
        {
            //player.curHP = player.maxHp;
            Destroy(gameObject);
            Debug.Log("All healed up");
        }
        else if (player.curHP <= player.maxHp)
        {
            player.curHP += healthToGive;
            healthBar.SetHealth(player.curHP);
            if(player.curHP >= player.maxHp)
            {
                player.curHP = player.maxHp;
            }
            Destroy(gameObject);
            Debug.Log("You gained health");
        }
        
        
    }
}
