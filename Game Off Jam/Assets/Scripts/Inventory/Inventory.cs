using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> inventoryList = new List<InventoryItem>();

    void OnEnable(){
        ObjectScript.onObjectCollected += Add;
    }

    void OnDisable(){
        ObjectScript.onObjectCollected -= Add;
    }

    public void Add(BaseObject itemData){
        InventoryItem newItem = new InventoryItem(itemData);
        inventoryList.Add(newItem);
        Debug.Log ($"Added {itemData.name} to the inventory!");
    }

    public void Remove(InventoryItem item){
        inventoryList.Remove(item);
    }
}
