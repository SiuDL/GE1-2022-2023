using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    // variable to store the text prompt using TextMeshPro component
    [SerializeField]
    private TextMeshProUGUI prompt;

    public void UpdateText(string text)
    {
       prompt.text = text;
    }
}
