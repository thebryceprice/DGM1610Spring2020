using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeftRightButtons : MonoBehaviour
{
    public UnityEvent leftButton;
    public UnityEvent rightButton;
    
    // Start is called before the first frame update
    void Start()
    {
        leftButton.Invoke();
        rightButton.Invoke();
    }

    public void OnMouseDown()
    {
        transform.right = Vector3.left;
        transform.right = Vector3.right;
    }
}
