using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    InputManager inputManager;
    Vector3 moveDirection;
    Rigidbody rigidBody;

    [Header("Movement Speed")]
    public float moveSpeed = 5f;

    private float acceleration = 10f;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        // get the object's rigid body that this script is attached to
        rigidBody = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<Rigidbody>();
        rigidBody.freezeRotation = true;
    }

    private void PlayerLocomotion()
    {
        moveDirection = transform.forward * inputManager.GetMoveInputY();
        moveDirection = moveDirection + transform.right * inputManager.GetMoveInputX();

        rigidBody.AddForce(moveDirection.normalized * moveSpeed * acceleration, ForceMode.Force);
    }

    public void ExecutePlayerMovement()
    {
        PlayerLocomotion();
    }
}
