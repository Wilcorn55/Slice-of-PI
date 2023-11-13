using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootContainerInteract : Interactable
{
    //Variables
    [SerializeField] GameObject closedChest;
    [SerializeField] GameObject openedChest;
    [SerializeField] GameObject puzzle;
    [SerializeField] bool opened;
    [SerializeField] bool hasPuzzle;
    public static bool GameIsPaused = false;

    public Item item;
    public int count = 1;

    //Interact will open a chest or loot container
    public override void Interact(Character character)
    {
        if (opened == false) 
        {
            opened = true;
            closedChest.SetActive(false);
            openedChest.SetActive(true);
        }

        if(hasPuzzle == true)
        {
            puzzle.SetActive(true);
        }
        else
        {
            puzzle.SetActive(false);

            if(GameManager.instance.inventorycontainer != null) 
            {
                GameManager.instance.inventorycontainer.Add(item, count);
            }
            else {
                Debug.LogWarning("No Inventory Space"); 
                    }
        }
    }
}
