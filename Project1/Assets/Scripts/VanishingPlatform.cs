using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VanishingPlatform : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Disappear();
        }
    }

    
    void Disappear()
    {
        gameObject.SetActive(false);
    }
}