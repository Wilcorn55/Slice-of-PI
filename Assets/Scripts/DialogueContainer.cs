using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/Dialogue/Dialogue")]

public class DialogueContainer : ScriptableObject
{
    //Variables
    public List<string> line;
    public Actor actor;
}
