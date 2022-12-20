using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : Interactable
{
    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        
    }
}
