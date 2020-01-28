using System;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Events;
public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    public bool stay;
    public bool exit;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        if (stay)
        {
            print("I'm here!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (exit)
        {
            print("I'm leaving!");
            gameObject.SetActive(false);
        }
    }
}
