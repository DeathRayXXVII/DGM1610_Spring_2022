using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public enum PickupType {Key}; //adding a enum array type
    public PickupType currentPickup; //deffinging a pick up type
    public int pickupAmount; //choosing the ammount to pick up
    private PlayerController playerController;
    private AudioSource source; //Audio sourece
    public AudioClip marker; //Audio clip
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        source = GetComponent<AudioSource>(); //Getting the audio source
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player")) //Making sure it is the player
        {  
            
            if(currentPickup == PickupType.Key) //checking the pick up type
            {
                source.PlayOneShot(marker,1.0f);//Play the Audio source on pickup
                playerController.key = pickupAmount; //adding the pick up amount to the player
                Debug.Log("Got a key");
            }
            Destroy(gameObject);
        }
    }
}
