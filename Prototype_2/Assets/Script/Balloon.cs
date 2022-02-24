using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive; //Score for poped balloon
    public int clickToPop = 3; //How many clicks to pop balloon
    public float balloonScale; //increass or decreases ballon on click
    public ScoreManager scoreManager; //A bariable to reference the ScoreManager
    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager conponent
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() 
    {
    clickToPop -= 1; //Reduce clicks by one
    transform.localScale += Vector3.one * balloonScale; //Increase balloon size

    if(clickToPop == 0)
    {
        scoreManager.IncreaseScoreText(scoreToGive);
        Destroy(gameObject);
    }
    }

}
