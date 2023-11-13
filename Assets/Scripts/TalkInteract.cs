using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkInteract : Interactable
{
    //Variables
    [SerializeField] public Actor actor;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    

    //Interact will initialize the dialog 
    public override void Interact(Character character)
    {
        DialogueManager.GetInstance().EnterDialogueMode(inkJSON, actor);
    }
}
