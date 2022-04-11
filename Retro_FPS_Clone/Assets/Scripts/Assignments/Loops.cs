using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //private int numEwoks = 0;
    private int ducksInPond = 99;
    // Start is called before the first frame update
    void Start()
    {
        /*for(int i = 20; i > numEwoks; i--)
        {
            Debug.Log("There are " + i + " Ewaks on a log!");
        }*/

        while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All the ducks have flown south for the Winter");
            ducksInPond --;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
