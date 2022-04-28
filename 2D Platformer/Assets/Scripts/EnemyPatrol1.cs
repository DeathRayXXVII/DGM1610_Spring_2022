using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol1 : MonoBehaviour
{
    public float speed; //Speed
    public float distance;
    private bool moveRight = true;
    public Transform groundDetection; //Ground game object detection
    public Transform wallDetection; //Wall game object detection
    public LayerMask whatIsWall; //Help find what is a wall
    public PlayerController player;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //Move the enemy Right
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down,  distance);
        RaycastHit2D wallInfo = Physics2D.Raycast(wallDetection.position, Vector2.down,  distance, whatIsWall);

        if(groundInfo.collider == false || wallInfo.collider == true) // Checking the direction of movement
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
