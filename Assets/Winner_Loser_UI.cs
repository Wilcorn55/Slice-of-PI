using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Winner_Loser_UI : MonoBehaviour
{
    public GameObject LoseMenuUI;

    public void ContinueGame()
    {
        SceneManager.LoadScene("Case2");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Resume() 
    {
        LoseMenuUI.SetActive(false);
    }

}
    
