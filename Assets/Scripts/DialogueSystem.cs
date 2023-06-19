using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueSystem : MonoBehaviour
{
    //Variables
    [SerializeField] TextMeshProUGUI targetText;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] Image portrait;

    DialogueContainer currentDialogue;
    int currentTextLine;

    [Range(0f, 1f)]
    [SerializeField] float visibleTextPercent;
    [SerializeField] float timePerLetter = 0.05f;
    float totalTimeToType, currentTime;
    string lineToShow;

    //Update will get the players input and will with display text 
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PushText();
        }
        TypeOutText();
    }
    
    //Type out text will 
    private void TypeOutText()
    {
        if (visibleTextPercent >= 1f) { return; }
        currentTime += Time.deltaTime;
        visibleTextPercent = currentTime / totalTimeToType;
        visibleTextPercent = Mathf.Clamp(visibleTextPercent, 0, 1f);
        UpdateText();
    }

    //Update text will update the displayed text
    void UpdateText() 
    {
        int letterCount = (int)(lineToShow.Length * visibleTextPercent);
        targetText.text = lineToShow.Substring(0, letterCount);
    }

    //Push Text will 
    private void PushText()
    {
        if(visibleTextPercent < 1f) 
        {
            visibleTextPercent = 1f;
            UpdateText();
            return;
        }
        
        if (currentTextLine >= currentDialogue.line.Count)
        {
            Conclude();
        }
        else
        {
            CycleLine();
        }
    }

    //Cycle line will display the text in a specific way
    void CycleLine()
    {

        lineToShow = currentDialogue.line[currentTextLine];
        totalTimeToType = lineToShow.Length * timePerLetter;
        currentTime = 0f;
        visibleTextPercent = 0f;
        targetText.text = "";

        currentTextLine += 1;


    }

    //Initialize will display the dialog box
    public void Initialize(DialogueContainer dialogueContainer)
    {
        Show(true);
        currentDialogue = dialogueContainer;
        currentTextLine = 0;
        CycleLine();
        UpdatePortrait();

    }

    //Update portrait will display the name and sprite of the npc the player is talking to 
    private void UpdatePortrait()
    {
        portrait.sprite = currentDialogue.actor.portrait;
        nameText.text = currentDialogue.actor.Name;
    }

    private void Show(bool v)
    {
        gameObject.SetActive(v);
    }

    //Conclude will finish the text
    private void Conclude()
    {
        Debug.Log("The Dialogue has ended");
        Show(false);
    }
}
