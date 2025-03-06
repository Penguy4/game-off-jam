using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{

    bool canCollect;

    public PromptManager promptManager;

    ICollectible collectible;

    InputAction interact;

    public Inventory inventory;

    void Start (){
        interact = InputSystem.actions.FindAction("Interact");
        interact.started += Interact;
    }

    void Interact(InputAction.CallbackContext ctx){
        bool isCollecting = ctx.started;
        if (isCollecting && canCollect && inventory.inventoryList.Count != 2){
            canCollect = false;
            promptManager.InteractPromptToggle(canCollect);
            collectible.Collect();
            collectible = null;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        collectible = col.GetComponent<ICollectible>();
        if (collectible != null){
            canCollect = true;
            promptManager.InteractPromptToggle(canCollect);
        }
    }
    
    void OnTriggerExit2D (Collider2D col){
        collectible = col.GetComponent<ICollectible>();
        if (collectible != null){
            collectible = null;
            canCollect = false;
            promptManager.InteractPromptToggle(canCollect);
        } 
    }

}
