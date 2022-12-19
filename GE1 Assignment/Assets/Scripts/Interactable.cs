using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract class to act a template for any object that can be interacted in game
// this class adheres to the Template Method Design Pattern
public abstract class Interactable : MonoBehaviour
{
    public string prompt;
    
    public void BaseInteract()
    {
        Interact();
    }

    // template method to be overridden by subclasses
    protected virtual void Interact(){}
}
