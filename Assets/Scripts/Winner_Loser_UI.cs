using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Winner_Loser_UI : MonoBehaviour
{
    //Variables
    public GameObject LoseMenuUI;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public PlayerMovement movement;

    //Continue will load the next scene
    public void ContinueGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int sceneName = currentScene.buildIndex;
        if (sceneName == 1)
        {
            Resume();
            SceneManager.LoadScene("Case2");
        }
        else if (sceneName == 2) 
        {
            Resume();
            SceneManager.LoadScene("MainMenu");
        }
        }

    //Main menu will load the main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Keep Playing will continue the game
    public void KeepPlaying() 
    {
        LoseMenuUI.SetActive(false);
        Resume();
    }

    //Resume will stop the pause menu displaying and will continue the game
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        movement.enabled = true;
    }


}

    

    
