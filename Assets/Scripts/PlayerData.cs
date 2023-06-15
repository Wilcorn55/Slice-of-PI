using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Gender { Male, Female }

[CreateAssetMenu(menuName = "Data/Player Data")]

public class PlayerData : ScriptableObject

{
    public Gender playerCharacterGender;
}
