using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private PlayerControler playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControler>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player") && playerController.key == 1)
        {
            Debug.Log("You opened the Door!");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Door is locked. You need a key!!");
        }
    }
}
