using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystemManager : MonoBehaviour
{
    //Variables
    public static DialogueSystemManager instance;
    //public DialogueSystem dialogueSystem;

    //Awake will initialize the dialogue system
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
