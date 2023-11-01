using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Data/Item")]
public class Item : ScriptableObject
{
    //Variables
    public string Name;
    public bool stackable;
    public Sprite icon;
    public string Description;


    public virtual string GetItemDescription()
{
    return Description;
}
}


