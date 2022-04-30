using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header ("Enemy Stats")]
    public int curHP; //Health
    public int maxHp; //Max health
    public EnemyHealth enemyHealth; //visual health
    public PlayerController player;
    public Rigidbody2D rb; //Enemy rigidbody
    [Header ("Particals")]
    public GameObject deathParticles;
    [Header ("Loot Drop")]
    public GameObject[] lootDrop;
    // Start is called before the first frame update
    [Header("Audio")]
    private AudioSource source; //Audio sourece
    public AudioClip marker; //Audio clip
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        curHP = maxHp;
        enemyHealth.SetHealth(maxHp); //Updates the health bar
        source = GetComponent<AudioSource>(); //Getting the audio source
    }

    public void TakeDamage(int damage)
    {
        
        curHP -= damage;
        enemyHealth.SetHealth(curHP);
        Debug.Log("I got hit");
        
        if(curHP <= 0)
        {
            source.PlayOneShot(marker,1.0f);//Play the Audio source on death
            die();
            LootDrop();
            
        }
    } 
    void die()
    {
        Instantiate (deathParticles, rb.transform.position, rb.transform.rotation); //Generate Death Particles 
        
        Destroy(gameObject);
    }
    void LootDrop()
    {
        //Pick a random loot drop from the loot drop array
        int lootIndex = Random.Range(0,lootDrop.Length);
        Debug.Log("Loot Drop");
        Instantiate(lootDrop[lootIndex], transform.position, Quaternion.identity);
    }  
}
