using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //Play game will load the case 1 scene
    public void PlayGame()
    {
        SceneManager.LoadScene("Case1");

    } 

    //Play game two will load the case 2 scene
    public void PlayGameTwo()
    {
        SceneManager.LoadScene("Case2");
    }

    //Quit game will cause the game to close 
    public void QuitGame()
    {
        Application.Quit();
    }

}
