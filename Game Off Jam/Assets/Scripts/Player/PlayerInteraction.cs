using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        ICollectible collectible = col.GetComponent<ICollectible>();
        if (collectible != null){
            collectible.Collect();
        }
    }

}
