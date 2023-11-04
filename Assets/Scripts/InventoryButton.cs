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
    private Item item;
   

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
    }

    public void OnCursorEnter()
    {
        GameManager.instance.DisplayItemInfo(item.name, item.GetItemDescription(), transform.position);
    }


    public void OnCursorExit()
    {
        GameManager.instance.DestroyItemInfo();
    }
}
