using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    public int scoreToGive; //Score for coin pick up
    public ScoreManager2 scoreManager;
    private AudioSource source; //Audio sourece
    public AudioClip marker; //Audio clip
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager2>();
        source = GetComponent<AudioSource>(); //Getting the audio source
    }

    private void OnTriggerEnter2D(Collider2D other) 
    { 
       
        if(other.CompareTag("Player")) //Making sure it is the player
        {
            scoreManager.IncreaseScoreText(scoreToGive);//add the score to the manager
             source.PlayOneShot(marker,1.0f);//Play the Audio source on pickup
            Destroy(gameObject);
        }
        
    }
}
