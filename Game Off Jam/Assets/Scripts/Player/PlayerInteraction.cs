using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{

    bool canCollect;

    ICollectible collectible;

    InputAction interact;

    void Start (){
        interact = InputSystem.actions.FindAction("Interact");
        interact.started += Interact;
    }

    void Interact(InputAction.CallbackContext ctx){
        bool isCollecting = ctx.started;
        if (isCollecting && canCollect){
            canCollect = false;
            collectible.Collect();
            collectible = null;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        collectible = col.GetComponent<ICollectible>();
        if (collectible != null){
            canCollect = true;
        }
    }
    
    void OnTriggerExit2D (Collider2D col){
        collectible = col.GetComponent<ICollectible>();
        if (collectible != null){
            collectible = null;
            canCollect = false;
        } 
    }

}
