using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputManager inputManager;
    private Vector3 moveDirection;
    private Rigidbody rigidBody;

    [SerializeField][Header("Movement Variables")]
    private float moveSpeed = 7f;
    private float drag;

    [Header("Grounded Variables")]
    private float height = 2;
    public LayerMask ground;
    [SerializeField]
    private bool grounded;

    private float acceleration = 10f;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        // get the object's rigid body that this script is attached to
        rigidBody = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<Rigidbody>();
        rigidBody.freezeRotation = true;
    }

    private void CheckGrounded()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, height * 0.5f + 0.1f, ground);

        if(grounded)
        {
            rigidBody.drag = drag;
        }
        else
        {
            rigidBody.drag = 0;
        }
    }

    private void PlayerLocomotion()
    {
        moveDirection = transform.forward * inputManager.GetMoveInputY();
        moveDirection = moveDirection + transform.right * inputManager.GetMoveInputX();

        rigidBody.AddForce(moveDirection.normalized * moveSpeed * acceleration, ForceMode.Force);
    }

    public void ExecutePlayerMovement()
    {
        CheckGrounded();
        PlayerLocomotion();
    }
}
