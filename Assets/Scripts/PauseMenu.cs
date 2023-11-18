using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Variables
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    [SerializeField]
    ItemContainer inventory;
    [SerializeField]
    List<InventoryButton> buttons;

    //Pause Menu 

    //Update is called once per frame
    //Update will check if the play triggers the pause menu with the esc button and will display the menu if the player has pressed esc
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //Resume will stop the pause menu displaying and will continue the game
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //Pause will cause the game to pause and bring up the pause menu 
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //Case Select tab

    //Main menu will take the player to the main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Resume();
    }

    //Play game one will load the case 1 scene
    public void PlayGameOne()
    {
        for (int i = 0; i < inventory.Slots.Count; i++)
        {
            buttons[i].Clean();
        }
        Resume();
        SceneManager.LoadScene("Case1");
        
    }

    //Play game two will load the case 2 scene
    public void PlayGameTwo()
    {
        for (int i = 0; i < inventory.Slots.Count; i++)
        {
            buttons[i].Clean();
        }
        Resume();
        SceneManager.LoadScene("Case2");
     
    }

    //Quit game will cause the game to close 
    public void QuitGame()
    {
        Application.Quit();
    }

}
