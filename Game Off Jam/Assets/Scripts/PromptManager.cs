using UnityEngine;
using UnityEngine.InputSystem;

public class PromptManager : MonoBehaviour
{
    public PlayerInput input;

    [HideInInspector]
    public string scheme;

    public GameObject[] prompts;

    GameObject correctPrompt;
    
    void Update(){
        scheme = input.currentControlScheme;

        if (input.currentControlScheme != scheme){
            UpdatePrompts();
        }
    }

    void UpdatePrompts(){
        switch (scheme){
            case "KeyboardMouse":
                correctPrompt = prompts[0];
                break;
            case "Xbox":
                correctPrompt = prompts[1];
                break;
            case "Playstation":
                correctPrompt = prompts[2];
                break;
            case "Switch":
                correctPrompt = prompts[3];
                break;
        } 
    }

    public void InteractPromptToggle(bool active){
        if (active == true){

        }
    }
}
