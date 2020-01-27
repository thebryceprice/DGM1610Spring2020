using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ammo : MonoBehaviour
{
    public int ammo;
    public UnityEvent aValue;

    void Start()
    {
        ammo = 0;
        aValue.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            ammo = ammo + 5;
            print("Ammo Collected");
        }
    }
}