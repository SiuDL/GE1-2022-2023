using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeLight : MonoBehaviour
{
    private Light lightSource; // The light that we want to fade
    [SerializeField]
    private float fadeSpeed = 1f; // The speed at which the light will fade in and out
    
    private bool switched = false;

    private void Awake()
    {
        lightSource = GameObject.FindGameObjectWithTag("Spotlight").GetComponentInChildren<Light>();
    }

    public void DimLight()
    {
        switch(switched)
        {
            case false:
                StartCoroutine(Fade());
                switched = true;
                break;
            case true:
                StopCoroutine(Fade());
                switched = false;
                break;
        }
    }

    IEnumerator Fade()
    {
        while (true)
        {
            // Fade the light in
            while (lightSource.intensity < 5f)
            {
                lightSource.intensity = Mathf.MoveTowards(lightSource.intensity, 5f, fadeSpeed * Time.deltaTime);
                yield return null;
            }

            // Fade the light out
            while (lightSource.intensity > 0f)
            {
                lightSource.intensity = Mathf.MoveTowards(lightSource.intensity, 0f, fadeSpeed * Time.deltaTime);
                yield return null;
            }
        }
    }

}

