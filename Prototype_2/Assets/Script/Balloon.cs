using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive; //Score for poped balloon
    public int clickToPop = 3; //How many clicks to pop balloon
    public float balloonScale; //increass or decreases ballon on click
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() 
    {
    clickToPop -= 1; //Reduce clicks by one
    transform.localScale += Vector3.one * balloonScale; //Increase balloon size

    if(clickToPop == 0)
    {
        Destroy(gameObject);
    }
    }

}
