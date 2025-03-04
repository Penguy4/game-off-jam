using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    // Movement Variables
    public Rigidbody2D rb;
    public float baseSpeed = 5f;
    public float sprintSpeed = 7.5f;
    private float speed;

    Vector2 movementDirection = Vector2.zero;

    // Input
    InputAction move, sprint;

    

    void Start(){
        move = InputSystem.actions.FindAction("Move");
        move.performed += Move;
        move.canceled += Move;

        sprint = InputSystem.actions.FindAction("Sprint");
        sprint.performed += Sprint;
        sprint.canceled += Sprint;

        speed = baseSpeed;
    }

    private void Move(InputAction.CallbackContext ctx){
        movementDirection = ctx.ReadValue<Vector2>();
    }

    private void Sprint(InputAction.CallbackContext ctx){
        bool sprintToggle = ctx.performed;

        switch (sprintToggle){
            case true:
                speed = sprintSpeed;
                break;
            case false:
                speed = baseSpeed;
                break;
        }
    }


    void Update(){

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movementDirection.x * speed, movementDirection.y * speed);
    }
    
}
