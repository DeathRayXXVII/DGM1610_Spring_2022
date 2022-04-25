using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    public HealthBar healthBar;
    public PlayerController playerController;
    public int healthToGive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        healthBar.SetHealth(healthToGive);
        Debug.Log("You gained health");
    }
}
