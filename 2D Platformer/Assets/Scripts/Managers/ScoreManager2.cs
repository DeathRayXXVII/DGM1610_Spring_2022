using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager2 : MonoBehaviour
{
    public int score; //Keep track of the score
    public TextMeshProUGUI scoreText; //Text Object to be moodified

    // Start is called before the first frame update
    void Start()
    {
     UpdateScoreText();   
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
    public void DecreaseScoreText(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }
    public void UpdateScoreText()
    {
        scoreText.text = "" + score;
    }
}
