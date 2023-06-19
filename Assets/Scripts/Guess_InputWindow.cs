using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Guess_InputWindow : MonoBehaviour
{
    //Variables
    private Button guessBtn;
    private Button cancelBtn;
    private TextMeshProUGUI titleText;
    private TMP_InputField inputField;

    //Awake contains the guess input window buttons 
    private void Awake()
    {
        Hide();
        guessBtn = transform.Find("guessBtn").GetComponent<Button>();
        cancelBtn = transform.Find("cancelBtn").GetComponent<Button>();
        titleText = transform.Find("titleText").GetComponent<TextMeshProUGUI>();
        inputField = transform.Find("inputField").GetComponent<TMP_InputField>();

    }

    //Show will show the guess input window
    public void Show() 
    {
        gameObject.SetActive(true);
    }

    //Hide will hide the guess input window 
    public void Hide() 
    {
        gameObject.SetActive(false);

    }



}
