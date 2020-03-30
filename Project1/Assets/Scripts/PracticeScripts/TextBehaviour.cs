﻿using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehaviour : MonoBehaviour
{
    private Text textObj;

    private void Start()
    {
        textObj = GetComponent<Text>();
    }

    public void ChangeText(string message)
    {
        textObj.text = message;
    }

    public void ChangeText(IntData obj)
    {
        textObj.text = obj.value.ToString();
    }
}