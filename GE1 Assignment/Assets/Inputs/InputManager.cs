using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerController controls;

    // variables to take in player/camera input from input system
    private Vector2 cameraInput;
    private Vector2 movementInput;
    private bool buttonInput;

    private float camInputY;
    private float camInputX;
    private float verticalInput;
    private float horizontalInput;

    private void Awake()
    {
        if(controls == null)
        {
            controls = new PlayerController();

            controls.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();
            controls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            controls.PlayerAction.Interact.performed += i => buttonInput = true;
        }

        controls.Enable();
    }

    public void ExecuteInputManager()
    {
        UpdateCameraInput();
        UpdateMovementInput();
    }

    private void DisableInputs()
    {
        controls.Disable();
    }

    private void UpdateCameraInput()
    {
        camInputY = cameraInput.y;
        camInputX = cameraInput.x;
    }

    private void UpdateMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }

    public bool ButtonPressed()
    {
        if(buttonInput)
        {
            buttonInput = false;
            return true;
        }
        return false;
    }

    public float GetCamInputY()
    {
        return camInputY;
    }

    public float GetCamInputX()
    {
        return camInputX;
    }

    public float GetMoveInputY()
    {
        return verticalInput;
    }

    public float GetMoveInputX()
    {
        return horizontalInput;
    }
}
