using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public string[] freindNames = {"Jessica", "Reftalia", "Becky", "Jana","Lucy"};
    public int[] numbers = {24,65, 25,65,84,23,68,102};

    // Start is called before the first frame update
    void Start()
    {
       /* Debug.Log("former friend " + freindNames[2]);
        Debug.Log(freindNames[1]+ " says hey!");
        freindNames[0] = "Veronica";
        Debug.Log("New Friend " + freindNames[0]);\
        */
        foreach(int numbers in numbers)
        {
            print(numbers);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
