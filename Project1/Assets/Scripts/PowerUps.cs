using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public float ammo;
    public float healing;
    public float money;
    
    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
}
