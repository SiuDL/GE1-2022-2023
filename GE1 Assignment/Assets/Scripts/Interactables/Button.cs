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
        buttonPressed = !buttonPressed;
        button.GetComponentInParent<Animator>().SetBool("IsPressed", buttonPressed);

        switch(gameObject.tag)
        {
            case "Button1":
                Debug.Log("Interacted with " + gameObject.tag);
                break;
            case "Button2":
                Debug.Log("Interacted with " + gameObject.tag);
                break;
            case "Button3":
                Debug.Log("Interacted with " + gameObject.tag);
                break;
        default:
                Debug.Log("Something went wrong");
                break;
        }
    }
}
