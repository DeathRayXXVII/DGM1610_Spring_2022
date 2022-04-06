using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem};
    public PickupType currentPickup;
    public int pickupAmount;
    private PlayerControler playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControler>();
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.key = pickupAmount;
                Debug.Log("you have picked up a golded key!");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerController.coins += pickupAmount;
                Debug.Log("you have picked up " + pickupAmount + " Coin's!");
            }
            else if(currentPickup == PickupType.Gem)
            {
                playerController.gems += pickupAmount;
                Debug.Log("you have picked up " + pickupAmount + " Gems!");
            }
            Destroy(gameObject);
        }
    }
}
