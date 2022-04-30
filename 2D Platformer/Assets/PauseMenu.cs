using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPause = false; //a bool to see if the game is paused or not
    public GameObject pasueMenu; //refrencing to the game object
    public int sceneToLoad; //finding a scene to load

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
    public void Resume()
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
    public void QuitGame()
    {
        SceneManager.LoadScene(sceneToLoad); //implementing the scene to load
    }
}
