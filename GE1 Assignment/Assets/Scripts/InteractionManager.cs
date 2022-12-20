using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private Transform cameraTrnsform;

    // variable to store the layermask of an interactable object
    [SerializeField]
    private LayerMask mask;

    [SerializeField]
    private float distance = 2f;
    private PlayerUI playerUI;
    private InputManager inputManager;
    
    private void Awake()
    {
        cameraTrnsform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        playerUI = GetComponent<PlayerUI>();
        inputManager = GetComponent<InputManager>();
    }

    // checks if the object can be interacted with
    private void CheckInteractable()
    {
        playerUI.UpdateText(string.Empty);
        // creating a ray that shoots out from the player towards where the camera is looking
        Ray ray = new Ray(cameraTrnsform.position, cameraTrnsform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance); // draws the ray (a straight line) from the players position

        RaycastHit hit; // variable to check what the raycast is hitting

        // if the end of the ray hits the layermask, perform this
        if(Physics.Raycast(ray, out hit, distance, mask))
        {
            // if the raycast came in contact with a component of the type Interactable, perform this
            if(hit.collider.GetComponentInChildren<Interactable>() != null)
            {
                // attach the component of type interactable to this local Interactable object
                Interactable interactable = hit.collider.GetComponentInChildren<Interactable>();
                playerUI.UpdateText(interactable.prompt); // display the prompt message to the UI
                if(inputManager.ButtonPressed())
                {
                    interactable.BaseInteract();
                }
            }
        }
    }

    public void ExecutePlayerInteract()
    {
        CheckInteractable();
    }
}
