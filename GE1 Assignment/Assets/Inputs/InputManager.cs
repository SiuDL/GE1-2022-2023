using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerController controls;

    // variables to take in player/camera input from input system
    private Vector2 camInput;

    private float camInputY;
    private float camInputX;

    private void Awake()
    {
        if(controls == null)
        {
            controls = new PlayerController();

            controls.PlayerMovement.Camera.performed += i => camInput = i.ReadValue<Vector2>();
        }

        controls.Enable();
    }

    private void DisableInputs()
    {
        controls.Disable();
    }

    private void Update()
    {
        camInputY = camInput.y;
        camInputX = camInput.x;
    }

    public float getCamInputY()
    {
        return camInputY;
    }

    public float getCamInputX()
    {
        return camInputX;
    }
}
