using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerMovement playerMovement;
    CameraManager cameraManager;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerMovement = GetComponent<PlayerMovement>();
        cameraManager = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraManager>();
    }

    private void Update()
    {
        inputManager.ExecuteInputManager();
        cameraManager.ExecuteCameraOperations();
    }

    private void FixedUpdate()
    {
        playerMovement.ExecutePlayerMovement();
    }
}
