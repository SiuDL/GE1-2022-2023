using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : Interactable
{
    [SerializeField]
    private GameObject button;
    private bool buttonPressed;
    private float delay = 0.2f;

    protected override void Interact()
    {
        buttonPressed = true;
        StartCoroutine(ButtonPress(button, buttonPressed));

        switch(gameObject.tag)
        {
            case "Button 1":
                Debug.Log("Interacted with " + gameObject.tag);
                break;
            case "Button 2":
                Debug.Log("Interacted with " + gameObject.tag);
                break;
            case "Button 3":
                Debug.Log("Interacted with " + gameObject.tag);
                break;
        default:
                Debug.Log("Something went wrong");
                break;
        }
    }

    IEnumerator ButtonPress(GameObject button, bool buttonPressed)
    {
        button.GetComponentInParent<Animator>().SetBool("IsPressed", buttonPressed);
        yield return new WaitForSeconds(delay);
        buttonPressed = false;
        button.GetComponentInParent<Animator>().SetBool("IsPressed", buttonPressed);
    }
}
