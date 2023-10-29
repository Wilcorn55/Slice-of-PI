using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootContainerInteract : Interactable
{
    //Variables
    [SerializeField] GameObject closedChest;
    [SerializeField] GameObject openedChest;
    [SerializeField] bool opened;

    //Interact will open a chest or loot container
    public override void Interact(Character character)
    {
        if (opened == false) 
        {
            opened = true;
            closedChest.SetActive(false);
            openedChest.SetActive(true);
            
        }
    }
}
