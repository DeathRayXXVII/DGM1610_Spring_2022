using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad; //Pick a scene to load

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); //scene to start the game
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit(); //quit the game/application
        Debug.Log("Game Quit");
    }
}
