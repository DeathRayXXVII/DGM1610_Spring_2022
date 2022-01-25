using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veriables : MonoBehaviour
{

    public int money; // int is a whole number
    public float changed = 0.5f; // floating point number or decimal
    public bool isDay; //booleans are true or false
    public bool starving;
    public string Password; // stirng is a text in quotation marks
    //const ID = 345; //cant be changed 

    // Start is called before the first frame update
    void Start()
    {
        money = 10;
        Debug.Log ("Money = " + money);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDay == true)
        {
            print ("It is Day");
        }else if (isDay ==  false)
        {
            print ("It is Night");
        }
        if (Password == "1234")
        {
            print("Your logged in");
        }else
        {
            print("Error Wrong Name");
        }
        if (starving == true)
        {
            money =0;
            print ("Your Broke");
        }
    }
}