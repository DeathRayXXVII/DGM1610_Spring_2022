using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed; //speed
    private Transform player; //Who it the player
    private Vector2 target; //our target
    public int damage; //How much damage
    public PlayerController pD; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }
    void onTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            pD.TakeDamage(damage);
            DestroyProjectile();
            Debug.Log("you have taken damage");
            
        }
            
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
