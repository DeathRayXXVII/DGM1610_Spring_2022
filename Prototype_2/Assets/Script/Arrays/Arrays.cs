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
    

    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
