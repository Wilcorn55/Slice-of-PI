using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private float typingSpeed = 0.04f;

    [Header("Dialogue UI")]

    [SerializeField]
    private GameObject dialoguePanel;

    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] Image portrait;

    [Header("Choices UI")]

    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;


    private Story currentStory;

    private bool canSkip = false;
    private bool submitSkip;

    public bool dialogueIsPlaying { get; private set; }

    private static DialogueManager instance;

    private Coroutine displayLineCouroutine;

    private const string NAME = "name";

    public TalkInteract talkInteract;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        }

        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            submitSkip = true;
        }
        if (!dialogueIsPlaying) 
        {
            return;
        }

        if (currentStory.currentChoices.Count == 0 && Input.GetMouseButtonDown(0)) 
        {
            ContinueStory();
            
        }
    }


    private void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);


        //get all the choices text
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices) 
        {
            choicesText[index] = choice.GetComponentInChildren <TextMeshProUGUI>();
            index++;
            
        }
    }

    public void EnterDialogueMode(TextAsset inkJSON, Actor actor) 
    {
        portrait.sprite = actor.portrait;

        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);
        
        ContinueStory();
       
    }

    private void ExitDialogueMode() 
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    private void ContinueStory() 
    {
        if (currentStory.canContinue)
        {
            if (displayLineCouroutine != null) 
            {
                StopCoroutine(displayLineCouroutine);
            }
            displayLineCouroutine = StartCoroutine(DisplayLine(currentStory.Continue()));

            DisplayChoices();
            HandleTags(currentStory.currentTags);
            
        }
        else
        {
            
            ExitDialogueMode();
        }
    }

    private void HandleTags(List<string> currentTags) 
    {
        //Loop through Tags
        foreach(string tag in currentTags) 
        {
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2) 
            {
                Debug.LogError("Tag not appropriatee" + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey) 
            {
                case NAME:
                    nameText.text = tagValue;
                    break;
                default:
                    Debug.LogWarning("Tag came in but is not being handeled" + tag);
                    break;
             
            }

        }


    }

    private void DisplayChoices() 
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        //Make sure the Ui can support the ammount of choices
        if(currentChoices.Count > choices.Length) 
        {
            Debug.LogError("More choices were given then the UI can support #=" + currentChoices.Count);
        }

        int index = 0;
        //enable and initilaze the choices
        foreach(Choice choice in currentChoices) 
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
            
        }

        for (int i = index; i < choices.Length; i++) 
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice() 
    {
        //wait a frame before we set the current selected object
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
        
    }

    public void MakeChoice(int choiceIndex) 
    {
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }
    

    private IEnumerator DisplayLine(string line) 
    {
        dialogueText.text = "";

        submitSkip = false;

        StartCoroutine(CanSkip());
     

        foreach (char letter in line.ToCharArray()) 
        {
            //if player has pressed button skip dialogue
            if (canSkip && submitSkip) 
            {
                submitSkip = false;
                dialogueText.text = line;
                break;
            }

            dialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        canSkip = false;
    }

    private IEnumerator CanSkip() 
    {
        canSkip = false;
        yield return new WaitForSeconds(0.5f);
        canSkip = true;
    }


}
