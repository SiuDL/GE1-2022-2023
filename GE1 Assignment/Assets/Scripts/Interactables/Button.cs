using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : Interactable
{
    [SerializeField]
    private GameObject button;
    private bool buttonPressed;

    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        buttonPressed = !buttonPressed;
        button.GetComponentInParent<Animator>().SetBool("IsPressed", buttonPressed);
    }
}
