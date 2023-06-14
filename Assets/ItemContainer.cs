using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemSlot 
{
    public Item item;
    public int count;
}



[CreateAssetMenu(menuName ="Data/Item Container")]
public class ItemContainer : ScriptableObject
{
    public List<ItemSlot> Slots;

    public void Add(Item item, int count = 1) 
    {
        if(item.stackable == true) 
        {
            ItemSlot itemslot = Slots.Find(x => x.item == item);
            if (itemslot != null) 
            {
                itemslot.count += count;
            }
            else
            {
                itemslot = Slots.Find(x => x.item == null);
                if (itemslot != null) 
                {
                    itemslot.item = item;
                    itemslot.count = count;
                }
            }
        }
        else 
        {
            //add non stackable item to our item container
            ItemSlot itemSlot = Slots.Find(x => x.item == null);
            if (itemSlot != null)
            {
                itemSlot.item = item;
            }
        }

    }
}
