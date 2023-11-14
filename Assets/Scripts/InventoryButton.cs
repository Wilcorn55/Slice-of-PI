using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryButton : MonoBehaviour
{
    //Variables
    [SerializeField] Image icon;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI itemName;
    [SerializeField] TextMeshProUGUI itemDescription;

    public Transform canvas;
   

    int myIndex;

    //Set index will set the index
    public void SetIndex(int index) 
    {
        myIndex = index;
    }

    //Set will display the sprite and amount in the inventory 
    public void Set(ItemSlot slot)
    {
        //item = newitem;
        icon.gameObject.SetActive(true);
        icon.sprite = slot.item.icon;


        itemName.text = slot.item.name;
        itemDescription.text = slot.item.Description;


        if (slot.item.stackable == true)
        {
            text.gameObject.SetActive(true);
            text.text = slot.count.ToString();
        }
        else
        {
            text.gameObject.SetActive(false);
        }

        
        
    }

    //Clean will display an empty inventory 
    public void Clean() 
    {
        icon.sprite = null;
        icon.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
        itemName.gameObject.SetActive(false);
        itemDescription.gameObject.SetActive(false);
    }

   public void OnCursorEnter()
    {
        itemName.gameObject.SetActive(true);
        itemDescription.gameObject.SetActive(true);
        canvas.gameObject.SetActive(true);
    }


    public void OnCursorExit()
    {
        itemName.gameObject.SetActive(false);
        itemDescription.gameObject.SetActive(false);
        canvas.gameObject.SetActive(false);
    }
}
