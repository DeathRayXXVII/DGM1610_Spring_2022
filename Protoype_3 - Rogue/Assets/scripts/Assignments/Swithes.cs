using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swithes : MonoBehaviour
{
    public string npcConv;
    public string yourOrder;
    public string truckMake;
    public string consoleNames;
    public int socialClass;
    public int speedRate;
    public int yearByDecade;
    public float;
    public float weaight;
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
        switch(weaight)
        {
            case 5:
                print("You need to lose some pounds!");
                break;
            case 4:
                print("still to big!");
                break;
            case 3:
                print("I like the progress!");
                break;
            case 2:
                print("You look great!");
                break;
            case 1:
                print("I did not reconise you! WOW!");
                break;
            case 0:
                print("I think you starved yourself too much!");
                break;
            default:
                print("Your scall is brocken! ERROR!");
                break;
        }
        switch(truckMake)
        {
            case "Ford":
                print("You have chossen wizely!");
                break;
            case "Dodge":
                print("We do not accept trash!");
                break;
            case "Chevey":
                print("You are wellcome to our fold!");
                break;
            case "Toyoda":
                print("The kids table is over there");
                break;
            default:
                print("That is not redneck enough to be reconized");
                break;
        }
        switch(consoleNames)
        {
            case "Nintendo":
                print("Lets a go!");
                break;
            case "Playstation":
                print("You almost achived PC level!");
                break;
            case "Xbox":
                print("Only childeren play xbox");
                break;
            case "sega":
                print("Sonic was the only thing going for you");
                break;
            default:
                print("That was not very populer so reconize");
                break;
        }

    switch(yourOrder)
        {
            case 2000:
                print("I am old!");
                break;
            case 2005:
                print("Dose not feel right seeing you all grown up");
                break;
            case 2010:
                print("Your the middle group so see you in 5");
                break;
            case 2015:
                print("Would you even know how to count this way");
                break;
            case 2020:
                print("You Wouldn't understand this anyway!")
                break;
            default:
                print("You are too old for this survey!");
                break;
        }
        
    }
}

    
