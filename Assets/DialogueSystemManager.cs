using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystemManager : MonoBehaviour
{
    public static DialogueSystemManager instance;
    public DialogueSystem dialogueSystem;

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
