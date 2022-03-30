using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swithes : MonoBehaviour
{
    //public string npcConv;

    public int socialClass;

    void Start() 
    {
        /*switch(npcConv)
        {
            case "Hello":
             print ("Hello citizen! May the blessings of Kratos be upon you!");
             break;
            case "Goodbye":
             print ("Goodbye! safe travels to you and your part");
             break;
            case "We are being attacked":
             print ("You run away in shamne, you coward!");
             break;
        }*/
        
        switch(socialClass)
        {
            case 5:
             Debug.Log("Hello your Magesty");
             break;
            case 4:
             Debug.Log("Hello Young Princess!");
             break;
            case 3:
             Debug.Log("Good evening Duke Urthor!");
             break;
            case 2:
             Debug.Log("Hello, Mayor!");
             break;
            case 1:
             Debug.Log("May I purchess some of your fine whines!");
             break;
            case 0:
             Debug.Log("Get away form me you riff raff!");
             break;
            default:
             Debug.Log("I do not talk with strangers!!");
             break;
        }
        
    }
}

    
