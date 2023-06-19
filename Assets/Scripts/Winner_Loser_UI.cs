using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Winner_Loser_UI : MonoBehaviour
{
    //Variables
    public GameObject LoseMenuUI;

    //Continue will load the next scene
    public void ContinueGame()
    {
        SceneManager.LoadScene("Case2");
    }

    //Main menu will load the main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Resume will continue the game
    public void Resume() 
    {
        LoseMenuUI.SetActive(false);
    }
    
}
    
