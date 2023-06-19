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
    public GameObject winMenuUI;
    public GameObject loseMenuUI;


    [SerializeField]
    private InputField input;

    [SerializeField]
    private TextMeshProUGUI text;

    

    private void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int sceneName = currentScene.buildIndex;
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
            winMenuUI.SetActive(true);


        }
        else if (tempguess != Murderer) 
        {
            loseMenuUI.SetActive(true);
        }
    }
}
