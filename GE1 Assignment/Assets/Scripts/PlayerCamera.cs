using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    InputManager inputManager;
    public Transform orientation;

    [Header("Mouse Sensitivity")]
    public float sensX = 30f;
    public float sensY = 30f;

    private float mouseX; 
    private float mouseY;

    private float rotationX;
    private float rotationY;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        inputManager = GetComponent<InputManager>();
    }
    
    private void CameraMovement()
    {
        // retrieve mouse input from the InputManager
        mouseX = inputManager.getCamInputX() * sensX * Time.deltaTime;
        mouseY = inputManager.getCamInputY() * sensY * Time.deltaTime;

        // pass mouse inputs in these rotation variables
        // will be used to rotate the camera
        rotationY += mouseX;
        rotationX -= mouseY;

        // clamping the angle of rotation on rotationX
        // keeps it so that the player can look any further up and down
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        // rotate camera
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        orientation.rotation = Quaternion.Euler(0, rotationY, 0);
    }

    //private void ;

    public void Update()
    {
        CameraMovement();
    }
}
