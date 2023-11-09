using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCanvasMaker : MonoBehaviour
{
    //Variables
    public static DialogueCanvasMaker instance;
    
    //Awake will initialize the dialog canvas maker
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
