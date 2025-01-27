using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : Interactable
{
    [SerializeField]
    private GameObject button;
    private RobotSwitcher switcher;
    private FadeLight fader;
    private ChangeLight changer;
    private bool buttonPressed;
    private float delay = 0.2f;

    private void Awake()
    {
        switcher = GameObject.FindGameObjectWithTag("Spawner").GetComponent<RobotSwitcher>();
        fader = GameObject.FindGameObjectWithTag("Spotlight").GetComponentInParent<FadeLight>();
        changer = GameObject.FindGameObjectWithTag("Spotlight").GetComponentInParent<ChangeLight>();
    }

    protected override void Interact()
    {
        buttonPressed = true;
        StartCoroutine(ButtonPress(button, buttonPressed));

        switch(gameObject.tag)
        {
            case "Button 1":
                Debug.Log("Interacted with " + gameObject.tag);
                switcher.ChangeRobot();
                break;
            case "Button 2":
                Debug.Log("Interacted with " + gameObject.tag);
                fader.DimLight();
                break;
            case "Button 3":
                Debug.Log("Interacted with " + gameObject.tag);
                changer.AlterLight();
                break;
            default:
                Debug.Log("Something went wrong - ButtonManager");
                break;
        }
    }

    IEnumerator ButtonPress(GameObject button, bool buttonPressed)
    {
        button.GetComponentInParent<Animator>().SetBool("IsPressed", buttonPressed);
        yield return new WaitForSeconds(delay);
        button.GetComponentInParent<Animator>().SetBool("IsPressed", false);
    }
}
