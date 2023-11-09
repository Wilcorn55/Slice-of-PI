using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkInteract : Interactable
{
    //Variables
    //[SerializeField] DialogueContainer dialogue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    

    //Interact will initialize the dialog 
    public override void Interact(Character character)
    {
        //GameManager.instance.dialogueSystem.Initialize(inkJSON);
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }
}
