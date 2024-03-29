using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2 : MonoBehaviour
{
    private PlayerController3 playerController;
    public int sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController3>();
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player") && playerController.key == 1)
        {
            Debug.Log("you opened the Door");
            Destroy(gameObject);
            SceneManager.LoadScene(sceneToLoad);
        }
        else if (other.CompareTag("Player") && playerController.key <= 1)
        {
            Debug.Log("Door is locked you need a key");
        }
    }
}
