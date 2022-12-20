using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : Interactable
{
    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }
}
