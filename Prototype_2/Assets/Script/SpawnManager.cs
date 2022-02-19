using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPreFabs;
    public int balloonIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomBalloon()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5,5),10, 0);
        int balloonIndex = Random.Range(0,balloonPreFabs.Length);
        Instantiate(balloonPreFabs[balloonIndex], spawnPos, balloonPreFabs[balloonIndex].transform.rotation);
    }
}
