using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Guess_InputWindow : MonoBehaviour
{
    private Button guessBtn;
    private Button cancelBtn;
    private TextMeshProUGUI titleText;
    private TMP_InputField inputField;

    private void Awake()
    {
        Hide();
        guessBtn = transform.Find("guessBtn").GetComponent<Button>();
        cancelBtn = transform.Find("cancelBtn").GetComponent<Button>();
        titleText = transform.Find("titleText").GetComponent<TextMeshProUGUI>();
        inputField = transform.Find("inputField").GetComponent<TMP_InputField>();

    }

    public void Show() 
    {
        gameObject.SetActive(true);
    }

    public void Hide() 
    {
        gameObject.SetActive(false);

    }



}
