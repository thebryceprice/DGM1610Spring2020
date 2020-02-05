using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour
{
    public float ammo;
    [SerializeField] private Text currentAmmoText;

    void Start()
    {
        ammo = 30;
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            ammoIncrease();
        }
    }

    void ammoIncrease()
    {
        ammo = ammo + 15;
        UpdateAmmo();
        gameObject.SetActive(false);
    }
    
    public void UpdateAmmo()
    {
        currentAmmoText.text = ammo.ToString("0");
    }
}