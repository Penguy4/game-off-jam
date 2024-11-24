using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<InventoryItem> inventory = new List<InventoryItem>();

    void OnEnable(){
        ObjectScript.onObjectCollected += Add;
    }

    void OnDisable(){
        ObjectScript.onObjectCollected -= Add;
    }

    public void Add(BaseObject itemData){
        InventoryItem newItem = new InventoryItem(itemData);
        inventory.Add(newItem);
        Debug.Log ($"Added {itemData.name} to the inventory!");
    }

    public void Remove(InventoryItem item){
        inventory.Remove(item);
    }
}
