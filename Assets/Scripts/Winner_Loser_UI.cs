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

    //Continue will load the next scene
    public void ContinueGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int sceneName = currentScene.buildIndex;
        if (sceneName == 1)
        {
            SceneManager.LoadScene("Case2");
            Resume();
        }
        else if (sceneName == 2) 
        {            
            SceneManager.LoadScene("MainMenu");
            Resume();
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
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


}

    

    
