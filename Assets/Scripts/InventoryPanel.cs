using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanel : MonoBehaviour
{
    //Variables
    [SerializeField] 
    ItemContainer inventory;
    [SerializeField]
    List<InventoryButton> buttons;

    //Start will show the inventory 
    private void Start()
    {
        SetIndex();
        Show();
    }

    //On Enable will enalble the players to see the inventory 
    private void OnEnable()
    {
        Show();
    }

    //Set index will set the inventory slow amounts
    private void SetIndex() 
    { 
        for(int i = 0; i < inventory.Slots.Count; i++) 
        {
            buttons[i].SetIndex(i);
        }
    
    }

    //Show will show the inventory items
    private void Show() 
    {
        for(int i = 0; i < inventory.Slots.Count; i++) 
        {
            if(inventory.Slots[i].item == null) 
            {
                buttons[i].Clean();
            }
            else 
            {
                buttons[i].Set(inventory.Slots[i]);
            }
        }
    }
}


