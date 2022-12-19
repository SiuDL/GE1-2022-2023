using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private InputManager inputManager;
    private Transform cameraPosition;
    private Transform playerPosition;

    [Header("Horizontal Mouse Sensitivity")]
    [SerializeField] private float sensX = 40f;
    [Header("Vertical Mouse Sensitivity")]
    [SerializeField] private float sensY = 40f;

    private float mouseX; 
    private float mouseY;

    private float rotationX;
    private float rotationY;

    private float minRotation = -90f;
    private float maxRotation = 90f;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        inputManager = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<InputManager>();
        cameraPosition = GameObject.FindGameObjectWithTag("CameraPosition").transform;
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;

        //transform.forward = cameraPosition.forward;
    }

    // attach camera to player
    private void AttachCamera()
    {
        transform.position = cameraPosition.position;
    }
    
    private void CameraMovement()
    {
        // retrieve mouse input from the InputManager
        mouseX = inputManager.GetCamInputX() * sensX * Time.deltaTime;
        mouseY = inputManager.GetCamInputY() * sensY * Time.deltaTime;

        // pass mouse inputs in these rotation variables
        // will be used to rotate the camera
        rotationY += mouseX;
        rotationX -= mouseY;

        // clamping the angle of rotation on rotationX
        // keeps it so that the player can look any further up and down
        rotationX = Mathf.Clamp(rotationX, minRotation, maxRotation);

        // rotate camera and player orientation
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        playerPosition.rotation = Quaternion.Euler(0, rotationY, 0);
    }

    public void ExecuteCameraOperations()
    {
        AttachCamera();
        CameraMovement();
    }
}
