using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] freindNames = {"Jessica", "Reftalia", "Becky", "Jana","Lucy"};
    public int[] numbers = {24,65, 25,65,84,23,68,102};
    public string[] food = {"Pizza", "Chesseburgar", "Enchaloda", "Chicken Sandwich", "French Toast"};
    public int[] age = {16, 18, 20, 25};
    public string[] drinkFlavors = {"Coke", "Pepsi"};
    public float[] decimals = {0.2f, 0.5f, 0.10f};
    public int[] days = {15, 18, 5, 20};
    //public bool[] consoleWar;
    public string[] consoleWars = {"Playstation", "Xbox", "Nintendo"};
    public float[] calc = {0.78f, 0.96f, 0.135f, 0.759f};
    public int[] number2 = {56134, 894, 48133, 124536};
    

    // Start is called before the first frame update
    void Start()
    {
        //System.Random random = new System.Random();
        Debug.Log("former friend " + freindNames[2]);
        Debug.Log(freindNames[1]+ " says hey!");
        freindNames[0] = "Veronica";
        Debug.Log("New Friend " + freindNames[0]);
        
        foreach(int numbers in numbers)
        {
            print(numbers);
        }
        
        Debug.Log("Which is better " + food[1] + " or " + food[3]);
        Debug.Log("Neather! " + food[4] + " is better!");

        foreach(int age in age)
        {
            print(age);
        }

        Debug.Log(drinkFlavors[0] + " is better than " + drinkFlavors[1]);
        
        foreach(float decimals in decimals)
        {
            print(decimals);
        }

        int total;
        total = numbers[0] * age[1] + days[2 / 3 - 0 + 1];
        print(total + " Days have passed since your awakening!");
        
        Debug.Log(freindNames[1] + " Bought you a new console " + consoleWars[0] + " Instead of " + consoleWars[1]);
        
        float calcD;
        calcD = calc[0] + calc[2] * calc[1] / calc[3];
        Debug.Log("You have " + calcD + " Hours tell you die!!!" );
        
        int total2;
        total2 = numbers[0] + numbers[1] + numbers[2] / numbers[3];
        Debug.Log( numbers[0] + " + " + number2[1] + " + " + number2[2] + " + " + number2[3] + " = " + total2 + " or your MOM! ohohohoh!!");
    }
}
