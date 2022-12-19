using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private Transform cameraTrnsform;

    [SerializeField]
    private LayerMask mask;

    [SerializeField]
    private float distance = 2f;
    
    private void Awake()
    {
        cameraTrnsform = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // checks if the object can be interacted with
    private void CheckInteractable()
    {
        // creating a ray that shoots out from the player towards where the camera is looking
        Ray ray = new Ray(cameraTrnsform.position, cameraTrnsform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance); // draws the ray (a straight line) from the players position

        RaycastHit hit; // variable to check what the raycast is hitting

        if(Physics.Raycast(ray, out hit, distance, mask))
        {
            if(hit.collider.GetComponentInChildren<Interactable>() != null)
            {
                Debug.Log("Button spotted");
            }
        }
    }

    public void ExecutePlayerInteract()
    {
        CheckInteractable();
    }
}
