using UnityEngine;
using System;

[Serializable]
public class InventoryItem
{
   public BaseObject objectItem;
    public int stackSize;

    public InventoryItem(BaseObject item){
        objectItem = item;
        AddItem();
    }

    public void AddItem(){
        stackSize++;
    }

    public void RemoveItem(){
        stackSize--;
    }
}
