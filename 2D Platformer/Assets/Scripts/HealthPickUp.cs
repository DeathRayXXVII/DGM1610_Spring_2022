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
        
        if (player.curHP >= player.maxHp) //Checking if the curent health is greater than max health
        {
            //player.curHP = player.maxHp;
            Destroy(gameObject);
            Debug.Log("All healed up");
        }
        else if (player.curHP <= player.maxHp)//Checking if the current health is less than max health
        {
            player.curHP += healthToGive; //add the given health to the current health
            healthBar.SetHealth(player.curHP); // set current health to the health bar
            if(player.curHP >= player.maxHp) //Checking if the curent health is greater than max health
            {
                player.curHP = player.maxHp; //If current health is over max set it to max health
            }
            Destroy(gameObject);
            Debug.Log("You gained health");
        }
        
        
    }
}
