using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GuessController : MonoBehaviour
{
    private string Murderer;
    private string guessMurderer;


    [SerializeField]
    private InputField input;

    [SerializeField]
    private TextMeshProUGUI text;

    Scene currentScene = SceneManager.GetActiveScene();

   

    private void Awake()
    {
        int sceneName = currentScene.buildIndex;
        Debug.Log(sceneName);
        if (sceneName == -1)  { Murderer = "sally"; }
        else if (sceneName == 3) { Murderer = "jonothan"; }
        text.text = "Who do you think did it?";
    }

    public void GetInput(string guess) 
    {
        string tempguess = guess.ToLower();
        CompareGuesses(tempguess);
        Debug.Log("You Entered " + tempguess);
        input.text = "";
    }

    void CompareGuesses(string tempguess) 
    {
        if (tempguess == Murderer) 
        {
            text.text = "You Guessed Right it was " + Murderer;
        }
        else if (tempguess != Murderer) 
        {
            text.text = "Your Guess was incorrect please try again";
        }
    }
}
