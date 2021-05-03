using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Type : MonoBehaviour
{
    public TMP_Text text;

    private void Start()
    {
        text.text = "";
    }
    public void AddText(string character)
    {
        text.text += character;
    }
    public void SubtractText()
    {
        if(text.text.Length != 0)
            text.text = text.text.Substring(0, text.text.Length - 1);
    }
}
