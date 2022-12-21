using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLight : MonoBehaviour
{
    private Light lightSource; // The light that we want to change the color of
    [SerializeField]
    private Color startColor; // The starting color of the light
    [SerializeField]
    private Color endColor; // The ending color of the light
    [SerializeField]
    private float duration = 3f; // The length of time it takes to transition between the start and end colors

    private bool switched = false;

    private void Awake()
    {
        lightSource = GameObject.FindGameObjectWithTag("Spotlight").GetComponentInChildren<Light>();
    }

    public void AlterLight()
    {
        switch(switched)
        {
            case false:
                StartCoroutine(ChangeColor());
                switched = true;
                break;
            case true:
                StopCoroutine(ChangeColor());
                switched = false;
                break;
        }
    }

    IEnumerator ChangeColor()
    {
        float elapsedTime = 0f;

        // Loop for the duration of the transition
        while (elapsedTime < duration)
        {
            // Set the light's color to a lerp between the start and end colors
            lightSource.color = Color.Lerp(startColor, endColor, elapsedTime / duration);

            // Increment the elapsed time
            elapsedTime += Time.deltaTime;

            // Wait until the next frame
            yield return null;
        }

        // Set the light's color to the final color
        lightSource.color = endColor;
    }
}

