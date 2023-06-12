using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodePanel : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI codeText;
    string codeTextValue = "";



    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;

        if (codeTextValue == "1234") 
            PlayerMovement.isSafeOpened = true;
        

        if (codeTextValue.Length >= 4)
            codeTextValue = "";
        
    }

    public void AddDigit(string digit) 
    {
        codeTextValue += digit;
    }
}
