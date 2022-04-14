using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    private int numEwoks = 0;
    private int numClones = 20;
    private int numDeadST = 0;
    private int numTieFighter = 0;
    private int numYunglings = 50;
    private int ducksInPond = 50;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 20; i > numEwoks; i--)
        {
            Debug.Log("There are " + i + " Ewaks on a log!");
        }
        for(int i = 0; i < numClones; i--)
        {
            Debug.Log( i + " more Clone Troopers are on there way!");
        }
        for(int i = 50; i > numDeadST; i--)
        {
            Debug.Log( "Theses Strom Troopers cant aim " + i);
        }
        for(int i = 20; i < numTieFighter; i++)
        {
            Debug.Log( "Number of Tie Fighters shot down " + i);
        }
        for(int i = 0; i > numYunglings; i--)
        {
             Debug.Log( "I have merderd  " + i + " Jedi younlings");
        }

        /*while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All the ducks have flown south for the Winter");
            ducksInPond --;
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
