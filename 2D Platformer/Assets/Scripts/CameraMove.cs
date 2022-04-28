using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public PlayerController player; // find the player
    public bool isFollowing; //making sure the camera is fallowing
    public float xOffset; //x offset for camera
    public float yOffset; // y offset for camera
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        isFollowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isFollowing)
        {
            transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z); //Getting the position of the player to follow it
        }
    }
}
