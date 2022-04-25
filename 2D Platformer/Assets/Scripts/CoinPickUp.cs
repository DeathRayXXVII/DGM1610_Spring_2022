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
        scoreManager.IncreaseScoreText(scoreToGive);
        Destroy(gameObject);
    }
}
