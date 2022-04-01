using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swithes : MonoBehaviour
{
    public string npcConv;
    public string yourOrder;
    public int socialClass;
    public int speedRate;
    public bool weather;

    void Start() 
    {
        switch(npcConv)
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
        }
        
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
        switch(weather)
        {
            case true:
                print ("The weather is Bad!");
                break;
            case false:
                print ("The weather is Great!");
                break;
        }
        switch(yourOrder)
        {
            case "Pizza":
                print("Your Pizza is ready!");
                break;
            case "Hamberger":
                print("How would you like you meat done!");
                break;
            case "Chicken":
                print("We only do chicken strips!");
                break;
            case "Hotdog":
                print("Would you like to try our footlong?");
                break;
            default:
                print("We do not seurve that garbage here!!!");
                break;
        }
        switch(speedRate)
        {
            case 5:
             Debug.Log("You have acheaved F&F level!!");
             break;
            case 4:
             Debug.Log("Your speed was increadable!");
             break;
            case 3:
             Debug.Log("That was not to bad!");
             break;
            case 2:
             Debug.Log("Your getting there, keep up the good work");
             break;
            case 1:
             Debug.Log("You need to work on that!");
             break;
            case 0:
             Debug.Log("You are to slow!");
             break;
            default:
             Debug.Log("You were so fast you invented time traval!!");
             break;
        }
        
    }
}

    
