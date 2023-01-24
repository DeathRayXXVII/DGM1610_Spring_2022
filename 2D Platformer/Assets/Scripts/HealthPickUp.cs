using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    public HealthBar2 healthBar;
    public PlayerController3 player;
    public int healthToGive;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController3>();
        healthBar = GameObject.Find("HealthBar_UI").GetComponent<HealthBar2>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
         if(other.CompareTag("Player")) //Making sure it is the player
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
}
