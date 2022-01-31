using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statments : MonoBehaviour
{

    public string lightColor;
    public string weather;
    public string hairColor;
    public int age;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lightColor == "Red")
        {
            Debug.Log("The Light is "+ lightColor +" SOTP!!");
        }
        else if (lightColor == "Yellow")
        {
            Debug.Log("The light is "+ lightColor +" Slow Down the HELL Down!!");
        }
        else if (lightColor == "Green")
        {
            Debug.Log("The light is "+ lightColor +" You are Free to Go!!");
        }
        else
        {
            Debug.Log("There isn't a stop light of the color");
        }

        if(weather == "Rain" || weather == "Snow")
        {
            Debug.Log("The Weathers not good, you might want a coat!");
        }
        else if (weather == "Sunny"|| weather == "Cloudy")
        {
            Debug.Log("You dont need a coat!");
        }

        if (hairColor == "Red" && age == 18)
        {
            Debug.Log("You can rid the Fire Dragon ride");
        }
        else if (hairColor == "Blonde" && age == 100)
        {
            Debug.Log("You are old enough to ride the unicorn ride");
        }

        if (age == 16 && speed <= 2)
        {
            Debug.Log ("You qualify for the uper devision!");
        }
        else if ( age >= 15 && speed >= 1)
        {
            Debug.Log ("You are not old enough and need more traning!");
        }
    }
}
