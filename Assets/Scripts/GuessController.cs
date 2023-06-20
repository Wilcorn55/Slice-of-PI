using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GuessController : MonoBehaviour
{
    //Variables
    private string Murderer;
    private string guessMurderer;
    public GameObject winMenuUI;
    public GameObject loseMenuUI;


    [SerializeField]
    private InputField input;

    [SerializeField]
    private TextMeshProUGUI text;

    //Awake will initialize the scene
    private void Awake()
    {
        //gives us the build index of the scene and sets the murders name
        Scene currentScene = SceneManager.GetActiveScene();
        int sceneName = currentScene.buildIndex;
        if (sceneName == 1)  { Murderer = "sally"; }
        else if (sceneName == 2) { Murderer = "jonothan"; }
        else { Murderer = "Blake"; }
        text.text = "Who do you think did it?";
    }

    //Get input will get the input of the player and will make the answer lowercase
    public void GetInput(string guess) 
    {
        string tempguess = guess.ToLower();
        CompareGuesses(tempguess);
        Debug.Log("You Entered " + tempguess);
        input.text = "";
    }
    
    //Compare guesses will compare the players input with the "Murderer" name and will display the corresponding UI
    void CompareGuesses(string tempguess) 
    {
        if (tempguess == Murderer) 
        {
            winMenuUI.SetActive(true);


        }
        else if (tempguess != Murderer) 
        {
            loseMenuUI.SetActive(true);
        }
    }
}
