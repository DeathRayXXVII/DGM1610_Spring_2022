using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPreFabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    //public int balloonIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomBalloon()
    {
        //Get a random position on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-5,5),7, 0);
        //Pick a random balloon from the balloon array
        int balloonIndex = Random.Range(0,balloonPreFabs.Length); 
        //Random balloon at spawn position
        Instantiate(balloonPreFabs[balloonIndex], spawnPos, balloonPreFabs[balloonIndex].transform.rotation);
    }
}
