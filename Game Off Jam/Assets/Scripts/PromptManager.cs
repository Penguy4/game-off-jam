using UnityEngine;
using UnityEngine.InputSystem;

public class PromptManager : MonoBehaviour
{
    public PlayerInput input;

    [HideInInspector]
    public string scheme;
    
    void Update(){
        scheme = input.currentControlScheme;
    }
}
