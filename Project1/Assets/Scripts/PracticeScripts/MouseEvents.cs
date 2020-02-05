using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseEnterEvent, mouseExitEvent, mouseDragEvent;
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }
}
