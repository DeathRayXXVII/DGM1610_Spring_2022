using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController player; //Player
    public GameObject currentCheakPoint; //Last cheak point found
    public Rigidbody2D rb; //Players rigidbody
    public GameObject playerOj; //Player object
    public ScoreManager scoreManager;
    public HealthBar healthBar; //visual health
    [Header ("Particals")]
    public GameObject deathParticles;
    public GameObject respawnParticles;
    [Header ("Respawn Delay")]
    public float respawnDelay; //Delay for respawning
    [Header ("Penalty on Death")]
    public int deathPenalty; //Penalty for dieing
    [Header ("Gravity reset")]
    private float gravityStore; // resets the stored gravity
    // Start is called before the first frame update
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }
    public IEnumerator RespawnPlayerCo()
    {
        Instantiate (deathParticles, rb.transform.position, rb.transform.rotation); //Generate Death Particles
        //Hide the player on death
        playerOj.SetActive(false); 
        rb.GetComponent<Renderer>().enabled = false;
        //Gravity Reset
        gravityStore = rb.GetComponent<Rigidbody2D>().gravityScale;
        rb.GetComponent<Rigidbody2D>().gravityScale = 0f;
        rb.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //Point penalty
        if (scoreManager.score >= 1)
        {
            scoreManager.DecreaseScoreText(deathPenalty);
            Debug.Log("Player Respwned");
        }
         if (scoreManager.score <= 1)
        {
            scoreManager.score = 0;
        }
        
        //Respon Delay
        yield return new WaitForSeconds(respawnDelay);
        //Gravity restore
        rb.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        //Match Player transfom poition with cheak point
        rb.transform.position = currentCheakPoint.transform.position;
        //Show Player
        playerOj.SetActive(true);
        rb.GetComponent<Renderer>().enabled = true;
        player.curHP = player.maxHp;
        healthBar.SetHealth(player.maxHp);
        //Show Respawn Particle
        Instantiate(respawnParticles, currentCheakPoint.transform.position, currentCheakPoint.transform.rotation);
    }
}
