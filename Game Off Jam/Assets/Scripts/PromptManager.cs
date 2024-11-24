using UnityEngine;
using UnityEngine.InputSystem;

public class PromptManager : MonoBehaviour
{
    public PlayerInput input;
    
    void Update(){
        string scheme = input.currentControlScheme;

        print (scheme);
    }
}
