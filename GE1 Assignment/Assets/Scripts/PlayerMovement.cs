using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    InputManager inputManager;
    Transform cameraTransform;
    Vector3 moveDirection;
    Rigidbody rigidBody;

    [Header("Movement Speed")]
    public float moveSpeed = 5f;

    private float acceleration = 10f;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        cameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        // get the object's rigid body that this script is attached to
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.freezeRotation = true;
    }

    private void PlayerLocomotion()
    {
        moveDirection = cameraTransform.forward * inputManager.GetMoveInputY();
        moveDirection = moveDirection + cameraTransform.right * inputManager.GetMoveInputX();

        rigidBody.AddForce(moveDirection.normalized * moveSpeed * acceleration, ForceMode.Force);
    }

    public void ExecutePlayerMovement()
    {
        PlayerLocomotion();
    }
}
