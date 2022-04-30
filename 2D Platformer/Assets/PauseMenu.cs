using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPause = false; //a bool to see if the game is paused or not
    public GameObject pasueMenu; //refrencing to the game object

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Resume()
    {
        pasueMenu.SetActive(false); //Setting the pause menu to deactive
        Time.timeScale = 1f; //Setting the time scale of the fame to original state
        gameIsPause = false; //chacking if the game is not paused
    }

    void Pause()
    {
        pasueMenu.SetActive(true);//Setting pasue menu to active
        Time.timeScale = 0f; //setting the time scale of the game to a frezze state
        gameIsPause = true; //cheacking if the game is paused
    }
}
