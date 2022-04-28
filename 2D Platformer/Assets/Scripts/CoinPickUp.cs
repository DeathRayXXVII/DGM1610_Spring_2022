using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public int scoreToGive; //Score for coin pick up
    public ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) //Making sure it is the player
        {
            scoreManager.IncreaseScoreText(scoreToGive);//add the score to the manager
            Destroy(gameObject);
        }
        
    }
}
