using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol1 : MonoBehaviour
{
    
    public float speed;
    public float distance;
    private bool moveRight = true;
    public Transform groundDetection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //Move the enemy Right
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down,  distance);

        if(groundInfo.collider == false) // Checking the direction of movement
        {
            if(moveRight == true)
            {
                transform.eulerAngles = new Vector3(0,-180,0); //Flip enemy at edge to move Left
                moveRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0,0,0); //Flip enemy at edge to move right
                moveRight = true;
            }
        }
    }
}
