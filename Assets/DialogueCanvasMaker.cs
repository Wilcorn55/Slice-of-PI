using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCanvasMaker : MonoBehaviour
{
    public static DialogueCanvasMaker instance;
    

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
