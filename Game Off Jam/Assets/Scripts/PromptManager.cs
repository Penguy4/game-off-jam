using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PromptManager : MonoBehaviour
{
    public PlayerInput input;

    public bool debugSwitch;

    [HideInInspector]
    public string scheme;

    public RawImage pcPrompt, xboxPrompt, psPrompt, switchPrompt;

    RawImage correctPrompt;

    void Start(){
        correctPrompt = pcPrompt;
    }
    
    void Update(){
        scheme = input.currentControlScheme;

        UpdatePrompts();
    }

    void UpdatePrompts(){
        switch (scheme){
            case "Keyboard&Mouse":
                correctPrompt = pcPrompt;
                break;
            case "Xbox":
                correctPrompt = xboxPrompt;
                break;
            case "Playstation":
                correctPrompt = psPrompt;
                break;
            case "Switch":
                correctPrompt = switchPrompt;
                break;
        } 
    }

    public void InteractPromptToggle(bool active){
        correctPrompt.enabled = active;
    }
}
