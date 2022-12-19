using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private InputManager inputManager;
    private PlayerMovement playerMovement;
    private CameraManager cameraManager;
    private InteractionManager playerInteract;

    private void Awake()
    {
        inputManager = GetComponentInChildren<InputManager>();
        playerMovement = GetComponentInChildren<PlayerMovement>();
        playerInteract = GetComponentInChildren<InteractionManager>();
        cameraManager = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraManager>();
    }

    private void Update()
    {
        inputManager.ExecuteInputManager();
        cameraManager.ExecuteCameraOperations();
        playerInteract.ExecutePlayerInteract();
    }

    private void FixedUpdate()
    {
        playerMovement.ExecutePlayerMovement();
    }
}
